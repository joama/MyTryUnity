using UnityEngine;
using System.Collections;

public class C_3_5_5 : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		//複製預製體
		GameObject obj = Instantiate(prefab) as GameObject;
		//設定遊戲物件obj的位置
		obj.transform.position = new Vector3(0,3,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
