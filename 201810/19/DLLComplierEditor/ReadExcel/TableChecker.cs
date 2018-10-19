using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace DLLComplierEditor
{
    public class TableChecker
    {
        public static void CheckOut(DataTable dt, List<ColumnInfo> colInfoAry)
        {
            string tableName = string.Empty;
            try
            {

                tableName = dt.TableName.ToString();
                //List<ColumnInfo> colInfoAry = ExcelReader.GetColumnInfoAry[dt.TableName];
                DataColumn indexCol = null;
                if (dt.Columns.Contains("rowOldIndex"))
                {
                    indexCol = dt.Columns["Columns"];
                }
                else
                {
                    indexCol = dt.Columns.Add("rowOldIndex", typeof(int));
                }
                //DataColumn indexCol = dt.Columns.Add("rowOldIndex", typeof(int));
                List<string> m_hasKeys = new List<string>();
                for (int i = dt.Rows.Count - 1; i >= 0; --i)
                {
                    string keyStr = "";
                    bool isHasData = false;
                    int empty = -1;
                    int rowIndex = i + 2;
                    dt.Rows[i][indexCol] = rowIndex;
                    for (int j = 0; j < colInfoAry.Count; ++j)
                    {
                        string value = Convert.ToString(dt.Rows[i][j]).Trim(' ');
                        if (value.Length > 0)
                            isHasData = true;
                        if (colInfoAry[j].m_isKey)
                            if (value.Length == 0)
                                empty = j;
                            else
                                keyStr += "_" + value;
                    }

                    if (!isHasData)
                        dt.Rows.RemoveAt(i);
                    else if (empty != -1)
                    {
                        UnityEngine.Debug.Log(string.Format("数据错误，表{0}[{1}][\"{2}\"]数据为空!", dt.TableName, rowIndex.ToString(), colInfoAry[empty].m_name));
                        dt.Rows.RemoveAt(i);
                    }
                    else if (keyStr.Length > 0)
                    {
                        if (m_hasKeys.Exists(t => t == keyStr))
                        {
                            UnityEngine.Debug.Log(string.Format("主键错误，表{0}[{1}]行的主键重复！", dt.TableName, rowIndex.ToString()));
                            dt.Rows.RemoveAt(i);
                        }
                        else
                            m_hasKeys.Add(keyStr);
                    }
                }
                CheckType(dt, colInfoAry);

            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("TableChecker CheckOut tableName : " + tableName);
                UnityEngine.Debug.LogError("TableChecker CheckOut Exception : " + ex.ToString());
            }
        }

        // 检测列的数据类型: int < double < string 
        public static void CheckType(DataTable dt, List<ColumnInfo> colInfoAry)
        {
            Regex regArray = new Regex(@"^\[[0-9,.\-\{\}]+\]$");
            for (int j = 0; j < colInfoAry.Count; ++j)
            {
                ColumnInfo colInfo = colInfoAry[j];
                colInfo.m_type = null;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    string value = dt.Rows[i][j].ToString().Trim(' ');
                    if (!colInfo.m_isRef && !colInfo.m_isComplex && regArray.IsMatch(value))
                    {
                        colInfo.m_type = typeof(string);
                        colInfo.m_isArray = true;
                        break;
                    }

                    if (colInfo.m_type != typeof(string))
                    {
                        Type t = TableChecker.GetTypeOfString(value);
                        if (t == null)
                            continue;
                        if (colInfo.m_type == typeof(double) && t == typeof(int))
                            continue;
                        colInfo.m_type = t;
                    }
                }
                // 如果列没有数据，则当做空字符处理.
                if (colInfo.m_type == null)
                    colInfo.m_type = typeof(string);
            }
        }

        // 检测一个数据的类型
        public static Type GetTypeOfString(string aStr)
        {
            aStr = aStr.Trim(' ');
            int iTemp;
            double fTemp;
            if (aStr.Length == 0)
                return null;
            else if (double.TryParse(aStr, out fTemp))
                return fTemp.GetType();
            else if (int.TryParse(aStr, out iTemp))
                return iTemp.GetType();
            else
                return typeof(string);
        }
    }
}
