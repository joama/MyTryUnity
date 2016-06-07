using UnityEngine;
using System.Collections;

public class C_3_5_3 : MonoBehaviour {
	public Texture texture;
	private GameObject obj;
	private Renderer render;

	// Use this for initialization
	void Start () {
		//抓取遊戲物件
		obj = GameObject.Find("Cube");
		//抓取該物件的渲染器
		render = obj.GetComponent<Renderer>();
	}

	void OnGUI(){
		if (GUILayout.Button ("增加色彩", GUILayout.Width (100), GUILayout.Height (50))) {
			//修改渲染器顏色為紅色
			render.material.color = Color.red;
		}
		if (GUILayout.Button ("增加貼圖", GUILayout.Width (100), GUILayout.Height (50))) {
			//加上元件貼圖
			render.material.mainTexture = texture;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
