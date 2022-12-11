using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuickKit;

[CreateAssetMenu(menuName = "GameMain/Dialog", fileName = "New Dialog Asset", order = 0)]
public class DialogData : ScriptableData
{
    public string title;
    [TextArea(100, 200)] public string contents;
    public override string Id => title;
}
