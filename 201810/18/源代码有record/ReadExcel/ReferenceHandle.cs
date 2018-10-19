using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;

namespace DLLComplierEditor
{
    public enum ErrRefenrence
    {
        ErrRefenrenceNone,      // 
        ErrRefenrenceNoTable,   // 参照的表不存在
        ErrRefenrenceNoCol,     // 参照的列不存在
        ErrRefenrenceRef,       // 
        ErrRefenrenceNoFind     // 参照的内容不存在
    };

    /*
     * 贴换参照数据
     */
    public class ReferenceHandle
    {
        // 替换表的参照信息
        public static void ReplaceReference(DataTable dt, List<ColumnInfo> fieldTypeAry)
        {
            for (int i = fieldTypeAry.Count - 1; i >= 0; --i)
            {
                if (!ReplaceColumn(dt, i, fieldTypeAry))
                {
                    dt.Columns.RemoveAt(i);
                }
            }
        }

        // 替换一列的参照信息
        private static bool ReplaceColumn(DataTable aDataTable, int aColIndex, List<ColumnInfo> fieldTypeAryo)
        {
            ColumnInfo colInfo = fieldTypeAryo[aColIndex];
            if (colInfo.m_isRef)
            {
                Regex reg = new Regex(@"^\w+\s*\{(\s*\w+\.\w+\s*)?\}$");
                if (reg.IsMatch(colInfo.m_param))
                {
                    string tmp = string.Format("{0}[\"{1}\"]", aDataTable.TableName, colInfo.m_name);
                    int startIndex = colInfo.m_param.IndexOf('{');
                    int endIndex = colInfo.m_param.IndexOf('}');
                    string param = colInfo.m_param.Substring(startIndex + 1, endIndex - startIndex - 1).Trim(' ');
                    if (ReferenceHandle.FindRefenrence(aDataTable, fieldTypeAryo, ref colInfo.m_name, ref colInfo.m_type, param, tmp, true) != ErrRefenrence.ErrRefenrenceNone)
                        return false;
                }
                else
                {
                    UnityEngine.Debug.LogError(string.Format("表头参照格式错误，表{0}[\"{1}\"]列的表头：{2} 格式不正确！", aDataTable.TableName, colInfo.m_name, colInfo.m_param));
                    return false;
                }
            }
            else if (colInfo.m_isComplex)
            {
                Regex regDivide = new Regex(@"\w+\s+\w+");
                bool isDivide = regDivide.IsMatch(colInfo.m_param.Substring(colInfo.m_param.IndexOf('[')));
                colInfo.m_param = colInfo.m_param.Replace(" ", "");
                Regex reg = new Regex(@"^\w+\{((\w+=\w+\.\w+,)*\w+=\w+\.\w+)?\}\[((\w+,)*\w+)?\]$");
                if (!isDivide && reg.IsMatch(colInfo.m_param))
                {
                    string param = colInfo.m_param.Substring(colInfo.m_param.IndexOf('{'));
                    if (!CheckComplexColumn(param, colInfo, aDataTable, fieldTypeAryo))
                        return false;
                    colInfo.m_type = typeof(string);
                }
                else
                {
                    UnityEngine.Debug.LogError(string.Format("表头拆分格式错误，表{0}[\"{1}\"]列的表头：{2} 格式不正确！", aDataTable.TableName, colInfo.m_name, colInfo.m_param));
                    return false;
                }
            }
            return true;
        }

        private static bool CheckComplexColumn(string value, ColumnInfo fInfo, DataTable dt, List<ColumnInfo> fieldTypeAryo)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            int index = value.IndexOf('[');
            string str = value.Substring(index + 1, value.IndexOf(']') - index - 1);
            string[] keys = str.Split(',');
            for (int i = 0; i < keys.Length; ++i)
                if (keys[i].Length != 0)
                    dic.Add(keys[i], null);
            str = value.Substring(1, value.IndexOf('}') - 1);
            string[] v = str.Split(',');
            string k = "";
            for (int i = 0; i < v.Length; ++i)
            {
                str = v[i];
                if (str.Length == 0)
                    continue;
                k = str.Substring(0, str.IndexOf('='));
                if (dic.ContainsKey(k))
                {
                    dic[k] = str.Substring(str.IndexOf('=') + 1);

                    string tmp = string.Format("{0}[\"{1}\"]", dt.TableName, fInfo.m_name);
                    if (ReferenceHandle.FindRefenrence(dt, fieldTypeAryo, ref fInfo.m_name, ref fInfo.m_type, dic[k], tmp, true) != ErrRefenrence.ErrRefenrenceNone)
                        return false;
                }
                else
                {
                    UnityEngine.Debug.LogError(string.Format("表头拆分格式错误，表{0}[\"{1}\"]列参照名称：{2}不在拆分名称中！", dt.TableName, fInfo.m_name, k));
                    return false;
                }
            }
            fInfo.m_splitDic = dic;
            return true;
        }

        /*
         * Function 1: 检查参照的目标是否正确（参照的表和列是否存在？） 2: 替换
         * @Param value: 替换内容（输出替换后的内容）
         * @Param t: 替换后的类型（输出参数）
         * @Param param：替换目标列的描述
         * @Param outStr：替换目标列的描述
         * @Param isCheck：是否只是检查，不做替换
         * @Param isPrint：是否打印错误提示
         */
        private static ErrRefenrence FindRefenrence(DataTable dt, List<ColumnInfo> colInfoAry, ref string value, ref Type t, string param, string outStr, bool isCheck, bool isPrint = true)
        {
            bool isHasTable = false;
            string[] paramStr = param.Split('.');
            if (dt.TableName == paramStr[0])
            {
                isHasTable = true;
                int refIndex = -1, keyIndex = -1;
                for (int i = 0; i < colInfoAry.Count; ++i)
                {
                    if (colInfoAry[i].m_isKey)
                        keyIndex = i;
                    if (colInfoAry[i].m_name == paramStr[1])
                        refIndex = i;
                }

                if (refIndex == -1)
                {
                    if (isPrint)
                        UnityEngine.Debug.LogError(string.Format("表头参照错误，表" + outStr + "列中的参照信息：{0} 指定的列在表{1}中不存在！", param, paramStr[0]));
                    return ErrRefenrence.ErrRefenrenceNoCol;
                }

                if (isCheck)
                {
                    if (colInfoAry[keyIndex].m_isRef || colInfoAry[keyIndex].m_isComplex)
                    {
                        if (isPrint)
                            UnityEngine.Debug.LogError(string.Format("表头参照错误，表" + outStr + "列中的参照信息：{0} 指定的列已经为参照列，该列不能再被其他表参照！", param));
                        return ErrRefenrence.ErrRefenrenceRef;
                    }
                    t = colInfoAry[keyIndex].m_type;
                    return ErrRefenrence.ErrRefenrenceNone;
                }

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    if (dt.Rows[i][refIndex].ToString() == value)
                    {
                        if (keyIndex != -1)
                        {
                            value = dt.Rows[i][keyIndex].ToString().Trim(' ');
                            t = colInfoAry[keyIndex].m_type;
                        }
                        return ErrRefenrence.ErrRefenrenceNone;
                    }
                }
            }

            if (!isHasTable)
            {
                if (isPrint)
                    UnityEngine.Debug.LogError(string.Format("表头参照错误，表" + outStr + "列中的参照信息：{0} 指定的表不存在！", param));
                return ErrRefenrence.ErrRefenrenceNoTable;
            }

            if (isPrint)
                UnityEngine.Debug.LogError(string.Format("查找替换错误，表" + outStr + "中的参照内容：{0} 在表{1}[\"{2}\"]的列中不存在该值！", value, paramStr[0], paramStr[1]));
            return ErrRefenrence.ErrRefenrenceNoFind;
        }

        /*public void GenOrderTable()
        {
            try
            {
                List<DataTable> newSet = new List<DataTable>();
                for (int n = ExcelReader.Instance().GetExcelDatas.Tables.Count - 1; n >= 0; --n)
                {
                    DataTable dt = ExcelReader.Instance().GetExcelDatas.Tables[n];
                    List<ColumnInfo> fieldTypeAry = ExcelReader.GetColumnInfoAry[dt.TableName];
                    DataTable newTable = new DataTable(dt.TableName);
                    for (int i = 0; i < fieldTypeAry.Count; ++i)
                        newTable.Columns.Add(fieldTypeAry[i].m_name, fieldTypeAry[i].m_type);
                    newTable.Columns.Add("rowOldIndex", typeof(int));

                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        DataRow newRow = newTable.NewRow();
                        bool isValid = true;
                        for (int j = 0; j < fieldTypeAry.Count; ++j)
                        {
                            string value = Convert.ToString(dt.Rows[i][j]).Trim(' ');
                            if (fieldTypeAry[j].m_isRef)
                            {
                                ColumnInfo fInfo = fieldTypeAry[j];
                                string tmp = string.Format("{0}[{1}][\"{2}\"]", dt.TableName, dt.Rows[i][dt.Columns.Count - 1].ToString(), fInfo.m_name);
                                int startIndex = fInfo.m_param.IndexOf('{');
                                int endIndex = fInfo.m_param.IndexOf('}');
                                string param = fInfo.m_param.Substring(startIndex + 1, endIndex - startIndex - 1).Trim(' ');
                                Type t = fInfo.m_type;
                                if (ReferenceHandle.FindRefenrence(ref value, ref t, param, tmp, false) != ErrRefenrence.ErrRefenrenceNone)
                                {
                                    isValid = false;
                                    break;
                                }
                            }
                            Type tt = fieldTypeAry[j].m_type;
                            if (value.Length == 0 && (tt == typeof(int) || tt == typeof(double)))
                                value = "0";
                            newRow[j] = Convert.ChangeType(value, tt);
                        }
                        newRow["rowOldIndex"] = Convert.ChangeType(dt.Rows[i]["rowOldIndex"], typeof(int));
                        if (isValid)
                            newTable.Rows.Add(newRow);
                    }

                    string orderStr = "";
                    for (int i = 0; i < fieldTypeAry.Count; ++i)
                        if (fieldTypeAry[i].m_isKey)
                            orderStr += fieldTypeAry[i].m_name + " asc,";
                    if (orderStr.Length > 0)
                        orderStr = orderStr.Remove(orderStr.LastIndexOf(','));

                    // 特殊处理
                    if (dt.TableName == "drop"
                    || dt.TableName == "drop_package"
                    || dt.TableName == "equipdrop")
                    {
                        orderStr = fieldTypeAry[0].m_name + " asc";
                    }
                    if (dt.TableName == "equipment")
                        orderStr = "EquipLevel asc, ID asc";

                    DataRow[] rows = newTable.Select(null, orderStr);
                    DataTable tempTable = newTable.Clone();
                    for (int i = 0; i < rows.Length; ++i)
                    {
                        DataRow newRow = tempTable.NewRow();
                        for (int j = 0; j < newTable.Columns.Count; ++j)
                            newRow[j] = rows[i][j];
                        tempTable.Rows.Add(newRow);
                    }
                    newSet.Add(tempTable);
                    ExcelReader.Instance().GetExcelDatas.Tables.RemoveAt(n);
                }

                for (int i = 0; i < newSet.Count; ++i)
                    ExcelReader.Instance().GetExcelDatas.Tables.Add(newSet[i]);
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("GenOrderTable Error: " + ex.ToString());
            }
        }*/
    }
}
