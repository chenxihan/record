using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Threading;
using DLLComplierEditor.Zip;
using DLLComplierEditor.Zip.Compression.Streams;

namespace DLLComplierEditor
{
    public static class GZipUtils
    {

        static public void UnZipFile(string originPath, string file, string unzipPath, string password = "")
        {
            using (ZipInputStream s = new ZipInputStream(File.OpenRead(originPath)))
            {
                s.Password = password;
                ZipEntry entry;
                while ((entry = s.GetNextEntry()) != null)
                {
                    string directoryName = Path.GetDirectoryName(entry.Name);
                    string fileName = Path.GetFileName(entry.Name);
                    if (file != fileName)
                        continue;

                    // create directory;
                    if (directoryName.Length > 0)
                    {
                        directoryName = unzipPath + directoryName;
                        Directory.CreateDirectory(directoryName);
                    }

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        using (FileStream streamWriter = File.Create(fileName))
                        {
                            WriteFile(streamWriter, s);
                        }
                    }
                    break;
                }
            }
        }

        static public void UnZipFileAll(string originPath, string unzipPath, string password = "")
        {
            using (ZipInputStream s = new ZipInputStream(File.OpenRead(originPath)))
            {
                s.Password = password;
                ZipEntry entry;
                while ((entry = s.GetNextEntry()) != null)
                {
                    string unRootPath = unzipPath;
                    string directoryName = Path.GetDirectoryName(entry.Name);
                    string fileName = Path.GetFileName(entry.Name);

                    // create directory;
                    if (!string.IsNullOrEmpty(directoryName))
                    {
                        unRootPath = Path.Combine(unzipPath, directoryName);
                        unRootPath = directoryName.Replace('\\', '/');
                        if (!Directory.Exists(unzipPath))
                        {
                            Directory.CreateDirectory(unzipPath);
                        }
                    }

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        fileName = Path.Combine(unRootPath, fileName);
                        fileName = fileName.Replace('\\', '/');
                        using (FileStream streamWriter = File.Create(fileName))
                        {
                            WriteFile(streamWriter, s);
                        }
                    }
                }
            }
        }
               
        static public void UnZipAndroidStreamingAssets(string originPath, string unzipPath, string password = "")
        {
            string APKStreamingAsset = "assets";
            string APKResourceData = APKStreamingAsset + "/bin";
            unzipPath = Path.Combine(unzipPath, "StreamingAssets");
            FileStream stream = null;
            try
            {
                stream = File.OpenRead(originPath);
            }
            catch (System.Exception ex)
            {
                Debug.LogException(ex);
            }
            using (ZipInputStream s = new ZipInputStream(stream))
            {
                s.Password = password;
                ZipEntry entry;
                while ((entry = s.GetNextEntry()) != null)
                {
                    string unRootPath = unzipPath;
                    string directoryName = Path.GetDirectoryName(entry.Name);
                    if (directoryName.Contains(APKResourceData))
                    {
                        continue;
                    }

                    if (!directoryName.Contains(APKStreamingAsset))
                    {
                        continue;
                    }
                    string fileName = Path.GetFileName(entry.Name);

                    // create directory;
                    if (!string.IsNullOrEmpty(directoryName))
                    {
                        unRootPath = Path.Combine(unRootPath, directoryName);
                        unRootPath = unRootPath.Replace(APKStreamingAsset, "");
                        unRootPath = unRootPath.Replace('\\', '/');
                        if (!Directory.Exists(unRootPath))
                        {
                            Directory.CreateDirectory(unRootPath);
                        }
                    }

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        fileName = Path.Combine(unRootPath, fileName);
                        fileName = fileName.Replace('\\', '/');
                        using (FileStream streamWriter = File.Create(fileName))
                        {
                            WriteFile(streamWriter, s);
                        }
                    }
                }
            }
        }

        static public void WriteFile(FileStream fileStream, ZipInputStream stream)
        {
            if (fileStream != null && stream != null)
            {
                int size = 1024;
                int index = 0;
                byte[] data = new byte[1024];
                while (true)
                {
                    size = stream.Read(data, 0, data.Length);
                    if (size > 0)
                    {
                        index += size;
                        fileStream.Write(data, 0, size);
                    }
                    else
                    {
                        break;
                    }
                }
                fileStream.Close();
            }
        }

        static public void GetFile(ref FileStreamInfo info, string fileName, ZipInputStream stream, int length)
        {
            if (info != null)
            {
                //FileStreamInfo info = new FileStreamInfo();
                info.Name = fileName;
                info.Length = length;
                info.Buffer = new byte[length];

                int size = 0;
                int index = 0;
                if (stream != null)
                {
                    while (true)
                    {
                        size = stream.Read(info.Buffer, 0, length);
                        if (size > 0)
                        {
                            index += size;
                        }
                        else
                        {
                            break;
                        }
                    }
                    //if( length != index ) {
                    //    NGUIDebug.Log( "WriteFileEx error: length " + length + " index " + index );
                    //} else {
                    //    GetMutex();
                    //    list.AddLast( info );
                    //    ReleaseMutex();
                    //}
                }
            }
        }

    }
}