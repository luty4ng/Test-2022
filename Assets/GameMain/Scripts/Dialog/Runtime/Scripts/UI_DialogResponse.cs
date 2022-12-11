using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Linq;
using UnityEngine.Events;
using QuickKit;

public class UI_DialogResponse : UIPanel
{
    public List<UI_DialogOption> ui_options = new List<UI_DialogOption>();
    private List<Option> currentOptions = new List<Option>();
    private VerticalLayoutGroup verticalLayoutGroup;
    private Sequence selectorSeq;
    private int m_CurrentIndex = 0;

    public int CurIndex
    {
        get
        {
            return m_CurrentIndex;
        }
    }
    protected override void Start()
    {
        verticalLayoutGroup = GetComponentInChildren<VerticalLayoutGroup>();
        ui_options = GetComponentsInChildren<UI_DialogOption>(true).ToList();
        selectorSeq = DOTween.Sequence();
        for (int i = 0; i < ui_options.Count; i++)
            ui_options[i].OnInit(this);
        this.gameObject.SetActive(false);
    }
    void Update()
    {
        if (!IsShown)
            return;

        foreach (var ui_option in ui_options)
            ui_option.OnTick();

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_CurrentIndex = (m_CurrentIndex + 1) % currentOptions.Count;
            EmphasizeOption(m_CurrentIndex);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_CurrentIndex = m_CurrentIndex - 1 == -1 ? currentOptions.Count - 1 : m_CurrentIndex - 1;
            EmphasizeOption(m_CurrentIndex);
        }
    }

    public override void Show(UnityAction callback = null)
    {
        base.Show(callback);
        animator.SetTrigger("FadeIn");
        animator.OnComplete(callback: callback);
        m_CurrentIndex = 0;

        for (int i = 0; i < currentOptions.Count; i++)
        {
            if (i >= ui_options.Count)
            {
                Debug.LogWarning("Too many options.");
                continue;
            }
            ui_options[i].OnReEnable(i);
            ui_options[i].gameObject.SetActive(true);
            ui_options[i].content.text = currentOptions[i].text;
        }
    }

    public override void Hide(UnityAction callback = null)
    {
        base.Hide(callback);
        animator.SetTrigger("FadeOut");
        animator.OnComplete(callback: callback);
        currentOptions.Clear();
        // foreach (var ui_option in ui_options)
        // {
        //     ui_option.gameObject.SetActive(false);
        // }
    }

    public void OnOptionEnter(UI_DialogOption option)
    {
        // m_CurrentIndex = option.index;
        // EmphasizeOption(m_CurrentIndex);
    }

    public void OnOptionExit(UI_DialogOption option)
    {

    }

    public void OnOptionDown(UI_DialogOption option)
    {

    }

    private void EmphasizeOption(int index)
    {
        UI_DialogOption optionUI =  ui_options[index];
    }

    public void UpdateOptions(List<Option> options) => currentOptions = options;

}
