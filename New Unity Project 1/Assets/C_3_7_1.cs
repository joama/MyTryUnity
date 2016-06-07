using UnityEngine;
using System.Collections;

public class C_3_7_1: MonoBehaviour {

	void OnGUI(){
		GUILayout.Label ("目前遊戲時間" + Time.time);
		GUILayout.Label ("遊戲時間的縮放" + Time.timeScale);
		GUILayout.Label ("上一幀所消耗的時間" + Time.deltaTime);
		GUILayout.Label ("固定增量時間" + Time.fixedTime);
		GUILayout.Label ("上一幀所消耗的固定時間" + Time.fixedDeltaTime);
		GUILayout.Label ("實際流失時間" + Time.realtimeSinceStartup);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
