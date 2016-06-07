using UnityEngine;
using System.Collections;

public class C_3_8_3_1 : MonoBehaviour {
	void OnGUI(){
		//遍覽所有Touch
		foreach(Touch touch in Input.touches){
			//輸出Touch資訊
			GUILayout.Label(string.Format("手指:{0} 狀態:{1} 位置:{2}",touch.fingerId,touch.phase.ToString(),touch.position));
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
