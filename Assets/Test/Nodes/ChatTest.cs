using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class ChatTest : Node {

    [Input(ShowBackingValue.Always,ConnectionType.Override)]
    public Empty enter;
    [Output]
    public Empty output;
    public int Id;

    public string Name;

    [TextArea]
    public string Context;

    public void ShowDialog()
    {
        Debug.Log(Context);
    }

	// Use this for initialization
	protected override void Init() {
		base.Init();
		
	}

    // Return the correct value of an output port when requested
    public override object GetValue(NodePort port) {
        //this.enter = GetInputValue<Empty>("enter", this.enter);
        //if(port.fieldName == "output")
        //{
            
        //}
		return null; // Replace this
	}
}
[Serializable]
public class Empty { }