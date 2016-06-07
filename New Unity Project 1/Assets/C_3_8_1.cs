using UnityEngine;
using System.Collections;

public class C_3_8_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//按下鍵盤A鍵
		if(Input.GetKeyDown(KeyCode.A)){
			//...
		}
		//按住鍵盤A鍵
		if(Input.GetKey(KeyCode.A)){
			//...
		}
		//鬆開鍵盤A鍵
		if(Input.GetKeyUp(KeyCode.A)){
			//...
		}
		//按下鍵盤左Shift鍵
		if(Input.GetKeyDown(KeyCode.LeftShift)){
			//...
		}
		//按住鍵盤Shift鍵
		if(Input.GetKey(KeyCode.LeftShift)){
			//...
		}
		//鬆開鍵盤Shift鍵
		if(Input.GetKeyUp(KeyCode.LeftShift)){
			//...
		}
		//按下滑鼠左鍵
		if(Input.GetMouseButtonDown(0)){
			//...
		}
		//按住滑鼠左鍵
		if(Input.GetMouseButton(0)){
			//...
		}
		//鬆開滑鼠左鍵
		if(Input.GetMouseButtonUp(0)){
			//...
		}
		//按下滑鼠右鍵
		if(Input.GetMouseButtonDown(1)){
			//...
		}
		//按住滑鼠右鍵
		if(Input.GetMouseButton(1)){
			//...
		}
		//鬆開滑鼠右鍵
		if(Input.GetMouseButtonUp(1)){
			//...
		}
	}
}
