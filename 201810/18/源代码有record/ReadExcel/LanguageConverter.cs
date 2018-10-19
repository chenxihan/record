using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace DLLComplierEditor
{
    /// <summary>
    /// 语言枚举
    /// </summary>
    public enum LanguageEnum
    {
        CH,     //中文
        TH,     //英文
        EN,     //英文
        JP,     //日文
        KR,     //韩语
        TW,     //台湾
        VIE     //越南
    }
    /// <summary>
    /// 语言装换器
    /// </summary>
    public class LanguageConverter
    {
        #region//静态实例
        public static readonly string _excelFileName = "LanguageConverter.xlsx";
        //目录
        private string _path = "";
        private static Dictionary<string, List<string>> _dict = new Dictionary<string, List<string>>();
        //静态实例
        private static LanguageConverter _instance = null;
        public static LanguageConverter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LanguageConverter();
                }
                return _instance;
            }           
        }
        #endregion

        //加载
        public void Load(string dir)
        {
            _path = dir + "/Locate/"+_excelFileName;
            _dict.Clear();
            UnityEngine.Debug.Log("Load:" + _path);
            if (System.IO.File.Exists(_path))
            {
                //_dict = ExcelFile.ReadExcelNormal(_path);
                _dict = ExcelFile.ReadExcelWorkSheet(_path);
                UnityEngine.Debug.Log("File path: " + _path);
            }
            else
            {
                UnityEngine.Debug.LogError("文件不存在或者路径不正确:" + _path);
            }
        }

        //添加文本
        public void AddText(string strValue)
        {
            if (string.IsNullOrEmpty(strValue)) return;
            //把前后的引号给去掉
            strValue = strValue.TrimStart('\"').TrimEnd('\"').Trim();  
            //判断是否存在,如果存在就返回           
            if (!_dict.ContainsKey(strValue)&&Regex.IsMatch(strValue, @"[\u4e00-\u9fa5]"))
            {
                //UnityEngine.Debug.Log("New:" + strValue);
                var row = new List<string>();
                row.Add(strValue);
                _dict[strValue] = row;
            }
        }

        //写文本
        public void Save()
        {
            UnityEngine.Debug.Log("需要保存到" + _path + "中共计 （" + _dict.Count + "） 条数据！");
            try
            {
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "保存语言文件LanguageConverter文件.", 0.5f);
                ExcelFile.SaveLanguageConverterExcel(_path, _dict);
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "保存语言文件LanguageConverter文件.", 0.7f);
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError(string.Format("保存数据到{0}错误,错误原因:{1}" + _path + ex.ToString()));
            }
            UnityEngine.Debug.Log("导表生成数据完成!");
        }
    }
}
