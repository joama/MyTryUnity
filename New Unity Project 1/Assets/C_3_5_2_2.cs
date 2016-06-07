using UnityEngine;
using System.Collections;

public class C_3_5_2_2 : MonoBehaviour {
	private GameObject obj;
	// Use this for initialization
	void Start () {
		//尋找整個場景中名為Cube的遊戲物件，並指派給obj變數
		obj = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
