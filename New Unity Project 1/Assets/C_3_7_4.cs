using UnityEngine;
using System.Collections;

public class C_3_7_4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	float rotateSpeed = 50f;

	// Update is called once per frame
	void Update () {
		//繞y軸自轉
		transform.rotation = Quaternion.Euler(0f,rotateSpeed*Time.time,0);
	}
}
