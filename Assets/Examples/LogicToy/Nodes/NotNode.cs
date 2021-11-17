using System.Linq;
using UnityEngine;

namespace XNode.Examples.LogicToy {
	[NodeWidth(140), NodeTint(100, 100, 50)]
	public class NotNode : LogicNode {
        //[Input, HideInInspector]
        [Input(ShowBackingValue.Always)] public bool input;
		[Output(ShowBackingValue.Always)] public bool output = true;
		public override bool led { get { return output; } }

		protected override void OnInputChanged() {
			bool newInput = GetPort("input").GetInputValues<bool>().Any(x => x);

			if (input != newInput) {
				input = newInput;
				output = !newInput;
				SendSignal(GetPort("output"));
			}
		}

		public override object GetValue(NodePort port) {
			return output;
		}
	}
}