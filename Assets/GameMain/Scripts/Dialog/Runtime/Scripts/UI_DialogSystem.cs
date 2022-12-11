using TMPro;
using UnityEngine;
using UnityEngine.UI;
using QuickKit;
using System.Collections.Generic;
using Febucci.UI;
using UnityEngine.Events;

public class UI_DialogSystem : UIPanel
{
    public TextMeshProUGUI speakerName;
    public TextMeshProUGUI contents;
    public TextAnimatorPlayer textAnimatorPlayer;
    public UI_DialogResponse uI_DialogResponse;
    public Image character;
    
    protected override void OnStart()
    {
        base.OnStart();
    }

    public void UpdateOptions(List<Option> options)
    {
        uI_DialogResponse.UpdateOptions(options);
    }

    public void ShowResponse(UnityAction callback = null)
    {
        uI_DialogResponse.Show(callback);
    }

    public void HideResponse(UnityAction callback = null)
    {
        uI_DialogResponse.Hide(callback);
    }

    public int GetSelection()
    {
        return uI_DialogResponse.CurIndex;
    }

    public override void Hide(UnityAction callback = null)
    {
        
    }

    public override void Show(UnityAction callback = null)
    {
        
    }
}
