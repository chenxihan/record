using System;
using System.Collections.Generic;

namespace DLLComplierEditor
{
    /// <summary>
    /// 操作Excel的类
    /// </summary>
    /// @author:丁华强
    /// @date:2016/10/12
    public class ExcelFile
    {
        // LanguageConverter表的列数
        private static int columnNum = 0;

        public static Dictionary<string, List<string>> ReadExcelWorkSheet(string excelPath)
        {
            Dictionary<string, List<string>> excelDict = null;
            try
            {
                Funcell.DIY.ExcelWorkSheet sheet = new Funcell.DIY.ExcelWorkSheet(excelPath);
                if (sheet == null)
                {
                    UnityEngine.Debug.LogError("读取Excel出错，无数据！" + excelPath);
                    return new Dictionary<string, List<string>>();
                }
                var values = sheet.Cells;
                
                // 行个数
                int rowNum = values.GetLength(0);
                if (rowNum > 0)
                {
                    // 列个数
                    columnNum = values.GetLength(1);
                    //列数不能为空
                    columnNum = columnNum > 0 ? columnNum : 1;
                    excelDict = new Dictionary<string, List<string>>(rowNum);
                    for (int i = 0; i < rowNum; i++)
                    {
                        List<string> columnList = new List<string>(columnNum);
                        var key = values[i, 0];
                        for (int j = 0; j < columnNum; j++)
                        {

                            string value = values[i, j];
                            columnList.Add(value);
                        }

                        if (!excelDict.ContainsKey(key))
                            excelDict.Add(key, columnList);
                    }
                }
                else 
                {
                    columnNum = 1;
                    excelDict = new Dictionary<string, List<string>>();
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("读取LanguageConverter出错！" + ex.Message);
            }
            
            return excelDict;
        }

        public static Dictionary<string, List<string>> ReadExcelNormal(string excelPath)
        {
            Dictionary<string, List<string>> excelDict = null;
            try
            {
                var excelInfo = Funcell.Editor.Excel.ExcelReader.ReadNormal(excelPath);
                if (excelInfo == null)
                {
                    UnityEngine.Debug.LogError("读取Excel出错，无数据！" + excelPath);
                    return new Dictionary<string, List<string>>();
                }
                string[,] values = excelInfo.Values;
                // 列数
                columnNum = (values.GetUpperBound(values.Rank - 1) + 1);
                // 行数
                int rowNum = values.Length / columnNum;
                excelDict = new Dictionary<string, List<string>>(rowNum);
                for (int i = 0; i < rowNum; i++)
                {
                    List<string> columnList = new List<string>(columnNum);
                    var key = excelInfo.Values[i, 0];
                    for (int j = 0; j < columnNum; j++)
                    {

                        string value = values[i, j];
                        columnList.Add(value);
                    }
                    UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "读取LanguageConverter文件" + key, (float)(i + 1) / rowNum);
                    excelDict.Add(key, columnList);
                }
                UnityEngine.Debug.Log("ReadExcelByExcelDll read count:" + excelDict.Count);
                UnityEditor.EditorUtility.ClearProgressBar();
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("读取LanguageConverter出错！" + ex.Message);
            }
            return excelDict;
        }

        // 读取带格式的表，有表头和主键的
        public static Dictionary<int,string[]> ReadExcel(string excelPath)
        {
            int index = 4;

            //var starttick = Environment.TickCount;
            var excelInfo = Funcell.Editor.Excel.ExcelReader.Read(excelPath);
            //UnityEngine.Debug.LogError("ReadExcelReadRead:"+ System.IO.Path.GetFileNameWithoutExtension(excelPath)+";;;"+ (Environment.TickCount - starttick) );
            if (excelInfo == null)
            {
                return null;
            }
            string[,] values = excelInfo.Values;
            int typeCount = excelInfo.Types.Count;
            int dictCount = 5;
            
            if (excelInfo.IdValuesTable != null)
            {
                dictCount += excelInfo.IdValuesTable.Count;
            }
            var  excelDict = new Dictionary<int, string[]>(dictCount);

            var mainKeyColumn = new List<string>(typeCount);
            for (int i = 0; i < typeCount; i++)
            {
                if (excelInfo.MainKeyIndex == i)
                {
                    mainKeyColumn.Add("1");
                }
                else
                {
                    mainKeyColumn.Add("");
                }
                
            }
            AddExcelPram(0, excelDict, mainKeyColumn, typeCount);
            AddExcelPram(1, excelDict, excelInfo.Keys, typeCount);
            AddExcelPram(2, excelDict, excelInfo.Types, typeCount);
            AddExcelPram(3, excelDict, excelInfo.MainDesc, typeCount);
            AddExcelPram(4, excelDict, excelInfo.Descs, typeCount);
            if (excelInfo.Values != null)
            {
                for (int i = 0; i < excelInfo.IdValuesTable.Count; i++)
                {
                    index++;
                    var columnList = new string[typeCount];
                    var key = excelInfo.Values[i, 0];
                    for (int j = 0; j < typeCount; j++)
                    {   
                        columnList[j] = values[i, j];
                    }
                    if (!excelDict.ContainsKey(index))
                    {
                        excelDict.Add(index, columnList);
                    }
                }
            }
            return excelDict;
        }

        private static void AddExcelPram(int index, Dictionary<int, string[]> excelDict, List<string> parmList, int typeCount)
        {
            var columnList = new string[typeCount];
            for (int i = 0; i < parmList.Count; i++)
            {
                columnList[i] = parmList[i];
            }
            excelDict.Add(index, columnList);
        }

        // 保存LanguageConverter
        public static void SaveLanguageConverterExcel(string path, Dictionary<string, List<string>> dict)
        {
            Funcell.Editor.Excel.NormalExcelInfo excelInfo = new Funcell.Editor.Excel.NormalExcelInfo();
            excelInfo.Name = "LanguageConverter";
            var iter = dict.GetEnumerator();
            try
            {
                int index = 0;
                if (excelInfo.Values == null)
                {
                    excelInfo.Values = new string[dict.Count, columnNum];
                }
                while (iter.MoveNext())
                {
                    for (int i = 0; i < iter.Current.Value.Count; i++)
                    {
                        excelInfo.Values[index, i] = iter.Current.Value[i];
                    }
                    index++;
                }
            }
            finally
            {
                iter.Dispose();
            }
            Funcell.Editor.Excel.ExcelWriter.Write(path, excelInfo);
        }
    }
}
