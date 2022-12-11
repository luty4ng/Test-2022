using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.EventSystems;
public class UI_DialogOption : QuickKit.UIData, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI content;
    public int index = 0;
    private Button button;
    public UI_DialogResponse response;
    private Sequence sequence;

    public void OnInit(UI_DialogResponse res)
    {
        
        response = res;
        content = GetComponentInChildren<TextMeshProUGUI>();
        sequence = DOTween.Sequence();
    }
    public void OnReEnable(int index)
    {
        this.index = index;
    }

    public void OnEmphasize()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        response.OnOptionDown(this);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        response.OnOptionEnter(this);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        response.OnOptionExit(this);
    }
}