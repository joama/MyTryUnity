using UnityEngine;
using System.Collections;

public class C_3_7_2 : MonoBehaviour {
	void OnGUI(){
		if(GUILayout.Button("產生隨機數值")){
			//產生隨機數值
			int i = Random.Range(0,10);
			Debug.Log ("隨機產生一個0~10之間的整數是:"+i);

			float f = Random.Range (0f,10f);
			Debug.Log ("隨機產生一個0~10之間的浮點數是:"+f);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
