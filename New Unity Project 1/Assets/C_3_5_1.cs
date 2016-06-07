using UnityEngine;
using System.Collections;

public class C_3_5_1 : MonoBehaviour {

	void OnGUI(){
		if (GUILayout.Button ("建立立方體", GUILayout.Height (50))) {
			//設定該模型預設為立方體
			GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//為物件加上一個鋼體，賦予物理屬性
			obj.AddComponent<Rigidbody>();
			//指定物件材質:紅色
			obj.GetComponent<Renderer>().material.color = Color.red;
			//設定物件的名稱
			obj.name = "Cube";
			//設定此模型材質的位置座標
			obj.transform.position = new Vector3(0,5f,0);
		}
		if(GUILayout.Button("建立球體",GUILayout.Height(50))){
			//設定該模型預設為球體
			GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			//為物件加上一個鋼體，賦予物理屬性
			obj.AddComponent<Rigidbody>();
			//指定物件材質:綠色
			obj.GetComponent<Renderer>().material.color = Color.green;
			//設定物件的名稱
			obj.name = "Sphere";
			//設定此模型材質的位置座標
			obj.transform.position = new Vector3(0,5f,0);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
