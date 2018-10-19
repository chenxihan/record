
using UnityEngine;
using UnityEngine.Profiling;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;

public class Test_For : MonoBehaviour
{
    public void Start()
    {
        RuntimeProfiler.instance.isRunProfiler = true;
    }
    public void StartTest()
    {
        int[] arr = new int[20000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        TimeRecord.StartRecord(Application.persistentDataPath + "/Record/test.txt", "foreach");
        Dictionary<int, int> dic = new Dictionary<int, int>(20000);

        int num = 0;
        foreach (var item in arr)
        {
            dic.Add(num, num++);
        }
        TimeRecord.StopRecord("foreach");

        Test test = new Test();
        test.StartTest();

        //var e = arr.GetEnumerator();
        //while (e.MoveNext())
        //{
        //    dic.Add(num, num++);
        //}

        GC.Collect();
        uint startSize = Profiler.GetMonoUsedSize();
        new List<int>(330);
        new List<int>(330);
        new List<int>(330);
        new List<int>(330);
        new List<int>(330);

        new List<int>(330);
        new List<int>(330);
        //new List<int>(330);
        //new List<int>(330);
        //new List<int>(330);
        new List<int>(246);
        uint stopSize = Profiler.GetMonoUsedSize();
        print("stopSize = " + stopSize + ", startSize = " + startSize + " ,增加了：" + (stopSize - startSize));

        GC.Collect();
        startSize = Profiler.GetMonoUsedSize();
        new List<int>(6516);
        stopSize = Profiler.GetMonoUsedSize();
        print("stopSize = " + stopSize + ", startSize = " + startSize + " ,增加了：" + (stopSize - startSize));

        GC.Collect();
        startSize = Profiler.GetMonoUsedSize();
        new List<int>(512);
        new List<int>(512);
        new List<int>(512);
        new List<int>(512);
        new List<int>(512);

        new List<int>(330);
        stopSize = Profiler.GetMonoUsedSize();
        print("stopSize = " + stopSize + ", startSize = " + startSize + " ,增加了：" + (stopSize - startSize));

        print("usedHeapSize : " + (float)Profiler.usedHeapSize / (1024*1024) + " M");
        print("GetMonoUsedSize : " + (float)Profiler.GetMonoUsedSize() / (1024 * 1024) + " M");
        print("GetMonoHeapSize : " + (float)Profiler.GetMonoHeapSize() / (1024 * 1024) + " M");
        print("GetTotalAllocatedMemory : " + (float)Profiler.GetTotalAllocatedMemory() / (1024 * 1024) + " M");
        print("GetTotalReservedMemory : " + (float)Profiler.GetTotalReservedMemory() / (1024 * 1024) + " M");
        print("GetTotalUnusedReservedMemory : " + (float)Profiler.GetTotalUnusedReservedMemory() / (1024 * 1024) + " M");

        print(Application.persistentDataPath + "/Record/");
        TimeRecord.StartRecord(Application.persistentDataPath + "/Record/test.txt", "for_1qw");
        for (int i = 0; i < 10000000; i++)
        {

        }
        TimeRecord.StopRecord("for_1qw");
        TimeRecord.recordDic.Clear();
    }

    private void OnDestroy()
    {
        //GC.Collect();
    }
}
