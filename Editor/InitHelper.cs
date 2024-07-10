
using UnityEditor;
using UnityEngine;

namespace ET
{
    public static class InitHelper
    {
        [MenuItem("ET/XET/Init", false, 1)]
        public static void Init()
        {
            HybridCLREditor.Init();

            ExcelEditor.Init();

            ProtoEditor.Init();

            LoaderEditor.Init();    

            AssetDatabase.Refresh();

            Debug.Log("Init finish!");
        }
    }
}