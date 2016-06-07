using UnityEngine;
using System.Collections;

public class C_3_6 : MonoBehaviour {
	public GameObject cube;
	public GameObject cylinder;
	void OnGUI(){
		if(GUILayout.Button("向左移動物體")){
			cube.transform.Translate(new Vector3(-0.5f,0f,0f));
		}
		if(GUILayout.Button("向右移動物體")){
			cube.transform.position = cube.transform.position + new Vector3(0.5f,0f,0f);
		}
		if(GUILayout.Button("放大物體")){
			cube.transform.localScale *= 1.2f;
		}
		if(GUILayout.Button("縮小物體")){
			cube.transform.localScale *= 0.8f;
		}
		if(GUILayout.Button("旋轉物體")){
			cube.transform.Rotate(new Vector3(0,10,0));
		}
		if(GUILayout.Button("圍繞球體旋轉物體")){
			cube.transform.RotateAround (cylinder.transform.position,Vector3.up,10);;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
