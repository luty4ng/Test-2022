using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterPool", menuName = "GameMain/CharacterPool", order = 0)]
public class CharacterPool : QuickKit.ScriptablePool
{
    public List<CharacterData> m_Characters;
    public override CharacterData GetData<CharacterData>(string name)
    {
        foreach (var character in m_Characters)
        {
            if (character.displayName == name)
            {
                return character as CharacterData;
            }
        }
        Debug.LogError($"Didn't find match character: " + name);
        return null;
    }

    public override CharacterData GetData<CharacterData>(int id)
    {
        throw new System.NotImplementedException();
    }


#if UNITY_EDITOR
    public override void Load()
    {
        Debug.Log(string.Format("加载{0}数据", name));
        m_Characters = new List<CharacterData>();
        foreach (string assetGuid in UnityEditor.AssetDatabase.FindAssets("t:CharacterData", new string[] { DataPath }))
        {
            string assetPath = UnityEditor.AssetDatabase.GUIDToAssetPath(assetGuid);
            CharacterData character = UnityEditor.AssetDatabase.LoadAssetAtPath<CharacterData>(assetPath);
            m_Characters.Add(character);
        }
    }

    public override void Clear()
    {
        Debug.Log(string.Format("清空{0}数据", name));
        m_Characters?.Clear();
    }
#endif
}

