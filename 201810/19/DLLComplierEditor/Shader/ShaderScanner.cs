using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace DLLComplierEditor
{
    /// <summary>
    /// Shader的目录扫描器
    /// </summary>
    public static class ShaderScanner
    {

        //属性信息列表
        private static Dictionary<string, int> _propertyInfoDict = new Dictionary<string, int>();
        //Shader列表
        private static Dictionary<string, string[]> _shaderList = new Dictionary<string, string[]>();
        private static Dictionary<string, Vector4[]> _shaderPropertValueList = new Dictionary<string, Vector4[]>();

        //所有的属性类型
        public static Dictionary<string, int> PropertyInfoDict
        {
            get
            {   
                return _propertyInfoDict;
            }
        }

        //Shader的列表
        public static Dictionary<string, string[]> ShaderList
        {
            get
            {
                return _shaderList;
            }
        }

        public static Dictionary<string, Vector4[]> ShaderPropertValueList
        {
            get
            {
                return _shaderPropertValueList;
            }

            set
            {
                _shaderPropertValueList = value;
            }
        }

        //进行扫描Shader目录
        public static void DoScan(string shaderDir)
        {
            //首先清理
            _shaderList.Clear();
            _propertyInfoDict.Clear();
            _shaderPropertValueList.Clear();

            //查找目录中的所有Shader文件
            string[] files = System.IO.Directory.GetFiles(shaderDir, "*.shader", SearchOption.AllDirectories);
            List<Shader> list = new List<Shader>();
            foreach (var file in files)
            {
                Shader s = AssetDatabase.LoadAssetAtPath<Shader>(file);
                if (s != null)
                {
                    list.Add(s);
                }
            }
            ProcessShader(list);
        }

        //分析Shader,并读取出所有的属性和类型
        private static void ProcessShader(List<Shader> allShaderList)
        {
            foreach (var s in allShaderList)
            {
                Material mat = new Material(s);
                //获取属性的数量
                int cnt = ShaderUtil.GetPropertyCount(s);// PrefabAssetEditorUtil.GetShaderPropertyCount(s);
                _shaderList[s.name] = new string[cnt];
                _shaderPropertValueList[s.name] = new Vector4[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    //获取属性名字
                    var name = ShaderUtil.GetPropertyName(s, i);
                    _shaderList[s.name][i] = name;
                    var stype = ShaderUtil.GetPropertyType(s, i);
                    switch (stype)
                    {
                        case ShaderUtil.ShaderPropertyType.Color:
                            _shaderPropertValueList[s.name][i] = mat.GetColor(name);
                            break;
                        case ShaderUtil.ShaderPropertyType.Vector:
                            _shaderPropertValueList[s.name][i] = mat.GetVector(name);
                            break;
                        case ShaderUtil.ShaderPropertyType.TexEnv:
                            {
                                var to = mat.GetTextureOffset(name);
                                var ts = mat.GetTextureScale(name);
                                _shaderPropertValueList[s.name][i] = new Vector4(to.x, to.y, ts.x, ts.y);
                            }
                            break;
                        case ShaderUtil.ShaderPropertyType.Float:
                        case ShaderUtil.ShaderPropertyType.Range:
                            _shaderPropertValueList[s.name][i] = new Vector4(mat.GetFloat(name), 0, 0, 0);
                            break;
                    }
                    
                    //获取属性的类型
                    int type = (int)ShaderUtil.GetPropertyType(s, i);
                    int t;
                    if (_propertyInfoDict.TryGetValue(name, out t))
                    {
                        if (t != type)
                        {
                            //如果是Range和Float,那么就设定默认为Float
                            if ((t == (int)ShaderUtil.ShaderPropertyType.Float && type == (int)ShaderUtil.ShaderPropertyType.Range) || (t == (int)ShaderUtil.ShaderPropertyType.Range && type == (int)ShaderUtil.ShaderPropertyType.Float))
                            {
                                _propertyInfoDict[name] = (int)ShaderUtil.ShaderPropertyType.Float;
                            }
                            else
                            {
                                Debug.LogError("在Shader[" + s.name + "]中发现属性" + name + "是类型:" + type + ";;而其他的是" + t);
                            }
                        }
                    }
                    else
                    {
                        _propertyInfoDict[name] = type;
                    }
                }
                GameObject.DestroyImmediate(mat,true);
            }

        }

    }
}
