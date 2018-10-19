using System;
using System.Collections.Generic;
using System.Xml;

namespace DLLComplierEditor
{
    /// <summary>
    /// 处理LanguageConverter.xlsx数据的读取和存储
    /// @Author: Dinghuaqiang
    /// @Date:   2016/11/16
    /// </summary>
    class LanguageConverterExcel : XmlReadExcel
    {
        private const string ExcelPath = "../../Gamedata/Locate/LanguageConverter.xlsx";

        private Dictionary<string, List<string>> _lanDict = new Dictionary<string, List<string>>();

        /// <summary>
        /// 各个国家（地区）语言数量,目前有6个语言种类
        /// </summary>
        private const int LAN_TYPE_COUNT = 6;

        public override void Parse()
        {
            base.Parse(ExcelPath);
        }

        public override void Save()
        {
            base.Save(ExcelPath);
        }

        /// <summary>
        /// 把生成好的翻译数据放入到Xml中，然后生成xlsx
        /// </summary>
        /// <param name="lanDict">要保存的翻译数据</param>
        public bool SaveDataToExcel(Dictionary<string, List<string>> lanDict)
        {
            UnityEngine.Debug.Log("正在向LanguageConveter.xlsx写入数据!");
            if (_sharedStringsXml == null) return false;
            try
            {
                var sheetDataNode = _sheetXml.DocumentElement.SelectSingleNode("sheetData") as XmlElement;
                if (sheetDataNode == null)
                {
                    sheetDataNode = _sheetXml.DocumentElement["sheetData"] as XmlElement;
                }
                sheetDataNode.RemoveAll();

                var sstNode = _sharedStringsXml.DocumentElement;
                sstNode.RemoveAll();

                // 记录一行数据的节点集合
                List<XmlNode> nodeList = new List<XmlNode>();
                int row = 0;
                foreach (var data in lanDict)
                {   
                    var rowdata = data.Value;
                    if (rowdata.Count == 0) continue;

                    // Excel中一行的翻译数据
                    WriteSingeRowData(rowdata, sstNode, nodeList);
                    row++;

                    CreateSheet1PosNode(row, sheetDataNode, nodeList);
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.Log("SaveDataToExcel Error: " + ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// 写一行的数据
        /// </summary>
        /// <param name="rowdata">Excel表一行的翻译数据</param>
        /// <param name="sstNode">sst节点</param>
        /// <param name="nodeList">一行数据的节点</param>
        private void WriteSingeRowData(List<string> rowdata, XmlElement sstNode, List<XmlNode> nodeList) 
        {
            // Excel中一行的翻译数据
            for (int i = 0; i < LAN_TYPE_COUNT; i++)
            {
                var nodeSi = _sharedStringsXml.CreateElement("si", _sheetXml.DocumentElement.NamespaceURI);
                var nodeT = _sharedStringsXml.CreateElement("t", _sheetXml.DocumentElement.NamespaceURI);
                nodeSi.AppendChild(nodeT);
                if (rowdata.Count > i)
                {
                    nodeT.InnerText = rowdata[i] == null ? string.Empty : rowdata[i];
                }
                else
                {
                    nodeT.InnerText = string.Empty;
                }
                sstNode.AppendChild(nodeSi);
                nodeList.Add(nodeSi);
            }
        }

        /// <summary>
        /// 创建sheet1.xml中的相关信息
        /// </summary>
        /// <param name="row">记录的sharedStrings.xml中字符串出现在Excel表格中相关位置信息</param>
        /// <param name="sheetDataNode">sheet1.xml中的sheetData节点</param>
        /// <param name="nodeList">一行数据的节点</param>
        private void CreateSheet1PosNode(int row, XmlElement sheetDataNode, List<XmlNode> nodeList) 
        {
            var rowNode = _sheetXml.CreateElement("row", _sheetXml.DocumentElement.NamespaceURI);
            rowNode.SetAttribute("r", row.ToString());
            rowNode.SetAttribute("spans", "1:15");

            sheetDataNode.AppendChild(rowNode);

            var index = nodeList.Count;

            for (int i = index - LAN_TYPE_COUNT, j = 0; i < index; i++, j++)
            {
                var cNode = CreateSheetNode("c", ((char)((int)'A' + j)).ToString(), row.ToString(), i.ToString(), true);
                rowNode.AppendChild(cNode);
            }
        }

        /// <summary>
        /// 创建sheet表中的节点，并且设置节点属性
        /// </summary>
        /// <param name="name"></param>
        /// <param name="collumName"></param>
        /// <param name="row"></param>
        /// <param name="value"></param>
        /// <param name="varChar"></param>
        /// <returns></returns>
        protected XmlElement CreateSheetNode(string name, string collumName, string row, string value, bool varChar = false)
        {
            var cNodeA = _sheetXml.CreateElement(name, _sheetXml.DocumentElement.NamespaceURI);
            // 设置节点属性 <c r="C4" s="1" t="s">
            cNodeA.SetAttribute("r", collumName + row);
            // 1代表string
            cNodeA.SetAttribute("s", "1");
            if (varChar) cNodeA.SetAttribute("t", "s");

            var vNodeA = _sheetXml.CreateElement("v", _sheetXml.DocumentElement.NamespaceURI);
            vNodeA.InnerText = value;
            cNodeA.AppendChild(vNodeA);

            return cNodeA;
        }

    }
}
