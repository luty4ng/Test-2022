using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public struct Mood
{
    public string moodName;
    public Sprite avatar;
}

[CreateAssetMenu(menuName = "GameMain/Character", fileName = "New Character Asset", order = 1)]
public class CharacterData : QuickKit.ScriptableData
{
    public override string Id => name;
    public string displayName;
    public List<Mood> moods;

    public Mood GetMood(string name)
    {
        for (int i = 0; i < moods.Count; i++)
        {
            if (moods[i].moodName.Equals(name))
            {
                return moods[i];
            }
        }
        return moods.Count > 1 ? moods.First() : default(Mood);
    }
}
