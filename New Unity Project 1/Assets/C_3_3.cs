using UnityEngine;
using System.Collections;

public class C_3_3 : MonoBehaviour {
	string text="";
	string myName="";
	void OnGUI()
	{
		//用標籤顯示文字
		GUILayout.Label("請輸入你的名字:");
		//用文字框輸入名字
		text = GUILayout.TextField(text);

		if (GUILayout.Button ("送出")) {
			myName = text;
		}
		//當myName不為空時，說明我們已經送出了名字，因此可顯示名字
		if (!string.IsNullOrEmpty (myName)) {
			GUILayout.Label ("送出成功，名字:"+myName);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
