using System.IO;
using System.Collections.Generic;
using System.Text;

public class TimeRecord
{
    public static Dictionary<string, RecordItem> recordDic = new Dictionary<string, RecordItem>();
    
    public static void StartRecord(string filePath, string name)
    {
        //如果有相同的name,就让报错
        recordDic.Add(name, new RecordItem(filePath, name, System.DateTime.Now.Ticks));
    }
    public static void StopRecord(string name)
    {
        RecordItem _item = recordDic[name];
        _item.stopTime = System.DateTime.Now.Ticks;
        _item.filePath = _item.filePath.Replace("\\", "/");
        string folderPath = _item.filePath.Remove(_item.filePath.LastIndexOf("/"));

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        FileStream fs = new FileStream(recordDic[name].filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        byte[] buffer = new byte[20480];//20KB
        int r = fs.Read(buffer, 0, 20480);
        string s = Encoding.Default.GetString(buffer, 0, r);
        if (r > 0)
        {
            s = s.Remove(0, s.LastIndexOf(",") + 1).Trim();
            fs.WriteByte(13);
            fs.WriteByte(10);
        }
        else
            s = "0";
        float _totalTime = ((float)(recordDic[name].stopTime - recordDic[name].startTime)) / 10000000;
        byte[] buffer2 = Encoding.Default.GetBytes(name + "\t,\t" + _totalTime + "\t,\t" + (float.Parse(s) + _totalTime));
        fs.Write(buffer2, 0, buffer2.Length);
        fs.Close();
    }
}
public class RecordItem
{
    public string filePath;
    public string name;
    public long startTime;
    public long stopTime;
    public RecordItem()
    {

    }
    public RecordItem(string strFilePath, string strName, long numStartTime)
    {
        filePath = strFilePath;
        name = strName;
        startTime = numStartTime;
    }
}