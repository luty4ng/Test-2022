using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using QuickKit;
using System.Linq;

public class DialogManager : SingletonBase<DialogManager>
{
    private Dictionary<string, DialogTree> m_DialogTrees = new Dictionary<string, DialogTree>();
    public DialogTree LatestDialog
    {
        get
        {
            return m_DialogTrees.Last().Value;
        }
    }
    public void Add(DialogTree tree)
    {
        if (!m_DialogTrees.ContainsValue(tree))
            m_DialogTrees.Add(tree.Id, tree);
    }

    public void Remove(string name)
    {
        if (m_DialogTrees.ContainsKey(name))
            m_DialogTrees.Remove(name);
    }

    public DialogTree Get(string name)
    {
        if (m_DialogTrees.ContainsKey(name))
            return m_DialogTrees[name];
        else
            return null;
    }

    public override void Clear()
    {
        m_DialogTrees?.Clear();
    }

    public static DialogTree CreateTree(string title)
    {
        // Debug.Log($"Create Tree");
        // DialogTree dialogTree = new DialogTree(title);
        // List<string> lines = new List<string>(text.Replace(((char)13).ToString(), "").Replace("\t", "").Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries));
        // foreach (var line in lines)
        // {
        //     Node<Dialog> node = new Node<Dialog>(dialogTree);
        //     node.nodeEntity = new Dialog();
        //     DialogPhaser.PhaseNode(node, line);
        // }
        // dialogTree.ExcuteAllBufferCommand<Dialog>();
        // dialogTree.OnBuildEnd();
        // EnqueueTree(dialogTree);
        // return dialogTree;

        return null;
    }
}