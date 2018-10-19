using Funcell.Editor.SharedLibary;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace DLLComplierEditor
{
    /// <summary>
    /// Shader变体集合生成器
    /// </summary>
    public class ShaderVariantCollectionGenerator
    {   
        /// <summary>
        /// 刷新Shader变体的集合
        /// </summary>
        public static void Execute()
        {
            Create(Defines.CN_SHADER_PATH, Defines.CN_SHADER_VARIANT_COLLECTION_PATH,
                new string[] { "/SceneBake/" },
                new string[] { "_USE_FLOW_FLUX_ON" }, true);            
        }

        /// <summary>
        /// 创建一个ShaderVariantCollection资源
        /// </summary>
        /// <param name="shaderDir"></param>
        /// <param name="svcpath"></param>
        /// <param name="ignoreKeys"></param>
        /// <param name="reset"></param>
        private static void Create(string shaderDir, string svcpath, string[] ignoreSubDirs = null, string[] ignoreKeys = null,bool reset = true)
        {
            var svc = AssetDatabase.LoadAssetAtPath<ShaderVariantCollection>(svcpath);
            if (svc == null)
            {
                svc = new ShaderVariantCollection();
                AssetDatabase.CreateAsset(svc, svcpath);
                svc = AssetDatabase.LoadAssetAtPath<ShaderVariantCollection>(svcpath);
            }

            if (reset)
            {
                svc.Clear();
            }

            var list = DoScan(shaderDir,ignoreSubDirs, ignoreKeys);
            foreach (var sv in list)
            {
                svc.Add(sv);
            }

            AssetDatabase.SaveAssets();
        }

        //进行扫描Shader目录
        private static List<ShaderVariantCollection.ShaderVariant> DoScan(string shaderDir, string[] ignoreSubDirs = null, string[] ignoreKeys = null)
        {
            List<ShaderVariantCollection.ShaderVariant> result = new List<ShaderVariantCollection.ShaderVariant>();
            //查找目录中的所有Shader文件
            string[] files = System.IO.Directory.GetFiles(shaderDir, "*.shader", SearchOption.AllDirectories);            
            foreach (var f in files)
            {
                var file = f.Replace('\\', '/');
                //1.忽略的目录
                bool ignore = false;
                if (ignoreSubDirs != null)
                {
                    foreach (var sd in ignoreSubDirs)
                    {
                        if (file.IndexOf(sd) >= 0)
                        {
                            Debug.LogWarning("忽略Shader:" + file);
                            ignore = true;
                            break;
                        }
                    }
                }
                if (!ignore)
                {
                    Debug.Log("开始处理Shader:" + file);
                    var shader = AssetDatabase.LoadAssetAtPath<Shader>(file);
                    if (shader != null)
                    {
                        ShaderVariantCollection.ShaderVariant sv = new ShaderVariantCollection.ShaderVariant();
                        sv.shader = shader;
                        sv.passType = UnityEngine.Rendering.PassType.Normal;
                        var hs = FuncellShaderUtils.GetShaderAllKeywords(sv.shader);
                        if (hs.Count > 0)
                        {
                            Debug.Log("1_KeywordsCount:" + hs.Count);
                            //如果有忽略的就删除掉.
                            if (ignoreKeys != null)
                            {
                                foreach (var k in ignoreKeys)
                                {
                                    if (hs.Remove(k))
                                    {
                                        Debug.LogWarning("移除Keyword:" + k + ";;Shader" + file);
                                    }
                                }
                            }
                            Debug.Log("2_KeywordsCount:" + hs.Count);
                            sv.keywords = new string[hs.Count];
                            hs.CopyTo(sv.keywords);
                        }
                        result.Add(sv);
                    }
                }
            }
            Debug.Log("ShaderVariantCollection Shader Count:"+result.Count);
            return result;
        }
    }
}
