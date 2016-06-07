using UnityEngine;
using System.Collections;

public class C_3_8_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//按下Fire1鍵
		if (Input.GetButtonDown ("Fire1")) {
			//...
		}
		//按住Fire1鍵
		if (Input.GetButton ("Fire1")) {
			//...
		}
		//鬆開Fire1鍵
		if (Input.GetButtonUp ("Fire1")) {
			//...
		}
	}
}
