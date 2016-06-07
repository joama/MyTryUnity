using UnityEngine;
using System.Collections;

public class C_3_5_4_1 : MonoBehaviour {
	public GameObject receiver;
	// Use this for initialization
	void Start () {
		//向本腳本所屬的遊戲物件發送ShowNumber訊息，並傳遞參數100
		receiver.SendMessage("ShowNumber",100,SendMessageOptions.DontRequireReceiver);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
