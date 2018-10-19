using System;
using System.Collections.Generic;
using System.Xml;

namespace DLLComplierEditor
{
    /// <summary>
    /// 单独处理MessageString表
    /// @auth 丁华强
    /// @date 2017/3/7
    /// </summary>
    class MessageStringExcel : XmlReadExcel
    {
        private string ExcelPath = string.Empty;

        public override void Parse()
        {
            base.Parse(ExcelPath);
        }

        public override void Save()
        {
            base.Save(ExcelPath);
        }

        public MessageStringExcel(string excelPath)
        {
            ExcelPath = excelPath;
        }

        public Dictionary<int, List<string>> GetMessageStringExcelData()
        {
            Dictionary<int, List<string>> _messageStrDict = new Dictionary<int, List<string>>();
            var sheetDataNode = _sheetXml.DocumentElement.SelectSingleNode("sheetData") as XmlElement;
            if (sheetDataNode == null)
            {
                sheetDataNode = _sheetXml.DocumentElement["sheetData"] as XmlElement;
            }
            //取_sheetXml中的sheetData标签的数据,然后取出每个row中的数据
            XmlNodeList sheetNodeList = sheetDataNode.GetElementsByTagName("row");
            //取_sharedStringsXml中每个si标签的数据
            XmlNodeList shardStrNodeList = _sharedStringsXml.GetElementsByTagName("si");
            int excelType = 0;//0 为java导出的表  1为stringTool  导出的表
            if (sheetNodeList[0].ChildNodes[0].InnerText != "1.0")
            {
                excelType = 1;
            }
            try
            {
                for (int i = 0; i < sheetNodeList.Count; i++)
                {
                    List<string> msgList = new List<string>();
                    int strKeyId = (int)float.Parse(sheetNodeList[i].ChildNodes[0].InnerText);
                    int strInfoId = 0;
                    int stridId = 0;

                    string strKey = string.Empty;
                    string strId = string.Empty;
                    string strInfo = string.Empty;

                    switch (excelType)
                    {
                        case 0:

                            if (shardStrNodeList[strKeyId].ChildNodes[0] != null)
                            {
                                strKey = shardStrNodeList[strKeyId].ChildNodes[0].InnerText;
                            }
                            if (sheetNodeList[i].ChildNodes[2] != null)
                            {
                                strInfoId = (int)float.Parse(sheetNodeList[i].ChildNodes[2].InnerText);
                                strInfo = shardStrNodeList[strInfoId].ChildNodes[0].InnerText;
                            }
                            // 表头
                            if (i < 5)
                            {
                                if (i == 0)
                                {
                                    strKey = float.Parse(sheetNodeList[i].ChildNodes[0].InnerText).ToString();
                                }
                                else if (i == 3)
                                {
                                    strKey = shardStrNodeList[6].ChildNodes[0].InnerText;
                                }
                                else
                                {
                                    if (sheetNodeList[i].ChildNodes[1] != null)
                                    {
                                        if (sheetNodeList[i].ChildNodes[1].InnerText != null)
                                        {
                                            int id = int.Parse(sheetNodeList[i].ChildNodes[1].InnerText);
                                            strId = shardStrNodeList[id].ChildNodes[0].InnerText;
                                        }
                                    }
                                }
                            }
                            // 数据
                            else
                            {
                                if (sheetNodeList[i].ChildNodes[1] != null)
                                {
                                    strId = float.Parse(sheetNodeList[i].ChildNodes[1].InnerText).ToString();
                                }
                            }
                            break;
                        case 1:

                            if (shardStrNodeList[strKeyId].ChildNodes[0] != null)
                            {
                                strKey = shardStrNodeList[strKeyId].ChildNodes[0].InnerText;
                            }
                            if (sheetNodeList[i].ChildNodes[2] != null)
                            {
                                strInfoId = (int)float.Parse(sheetNodeList[i].ChildNodes[2].InnerText);
                                strInfo = shardStrNodeList[strInfoId].ChildNodes[0].InnerText;
                            }

                            if (sheetNodeList[i].ChildNodes[1] != null)
                            {
                                stridId = (int)float.Parse(sheetNodeList[i].ChildNodes[1].InnerText);
                                strId = shardStrNodeList[stridId].ChildNodes[0].InnerText;
                            }
                            break;
                    }
                    msgList.Add(strKey);
                    msgList.Add(strId);
                    msgList.Add(strInfo);
                    _messageStrDict.Add(i, msgList);
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("MessageString 错误: " + ex.ToString());
            }
            return _messageStrDict;
        }
    }
}
