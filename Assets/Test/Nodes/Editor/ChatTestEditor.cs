using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;

[CustomNodeEditor(typeof(ChatTest))]
public class ChatTestEditor : NodeEditor
{
    public override void OnHeaderGUI()
    {
        base.OnHeaderGUI();
     //GUILayout.Label("Test", NodeEditorResources.styles.nodeHeader, GUILayout.Height(30));
    }
    public override void OnBodyGUI()
    {
        ChatTest  chat = target as ChatTest;
        base.OnBodyGUI();
        if(GUILayout.Button("ShowDialog"))
        {
            chat.ShowDialog();
        }
        if (GUILayout.Button("ShowNextDialog"))
        {
            ChatTest next = chat.GetOutputPort("output").Connection.node as ChatTest;
            next.ShowDialog();
        }
    }
}
