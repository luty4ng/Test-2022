using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuickKit;

[CreateAssetMenu(menuName = "GameMain/DialogPool", fileName = "DialogPool", order = 0)]
public class DialogPool : ScriptablePool
{
    [SerializeField] private List<DialogData> m_Dialogs;
    public override DialogData GetData<DialogData>(string name)
    {
        foreach (var dialog in m_Dialogs)
        {
            if (dialog.Id.Correction() == name.Correction())
            {
                return dialog as DialogData;
            }
        }
        Debug.LogWarning(string.Format("Can not find data {0} for {1}.", name, this.name));
        return default(DialogData);
    }

    public override DialogData GetData<DialogData>(int id)
    {
        throw new System.NotImplementedException();
    }


#if UNITY_EDITOR
    public override void Load()
    {
        Debug.Log(string.Format("加载{0}数据", name));
        m_Dialogs = new List<DialogData>();
        foreach (string assetGuid in UnityEditor.AssetDatabase.FindAssets("t:DialogData", new string[] { DataPath }))
        {
            string assetPath = UnityEditor.AssetDatabase.GUIDToAssetPath(assetGuid);
            DialogData dialog = UnityEditor.AssetDatabase.LoadAssetAtPath<DialogData>(assetPath);
            m_Dialogs.Add(dialog);
        }
    }

    public override void Clear()
    {
        Debug.Log(string.Format("清空{0}数据", name));
        m_Dialogs?.Clear();
    }
#endif
}