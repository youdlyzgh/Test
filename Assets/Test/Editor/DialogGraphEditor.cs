using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;
[CustomNodeGraphEditor(typeof(DialogGraph))]
public class DialogGraphEditor : NodeGraphEditor
{
    public override void OnGUI()
    {
        base.OnGUI();
        GUILayout.Space(3);

        GUILayout.BeginHorizontal();  //嵌套一个纵向布局
        if (GUILayout.Button("Test", GUILayout.Width(50), GUILayout.Height(30)))
        {

        }
        //GUILayout.FlexibleSpace();  //两个box控件上下对齐
        if (GUILayout.Button("Test1", GUILayout.Width(50), GUILayout.Height(30)))
        {

        }
        GUILayout.EndHorizontal();    //结束嵌套的纵向布局

        
    }
}
