using UnityEngine;
using System.Collections;

public class ChangeColorScript : MonoBehaviour {

	public Color yelow;
	public Color green;
	public Color mizu;
	public Color pink;
	public Color purple;

	public Color[] ran;

	public float timer;

	public int randomCount;

	public GameObject colorBox;

	// Use this for initialization
	void Start () {

		yelow = new Color(255, 255, 127, 255);
		purple = new Color(191, 127, 255, 255);
		pink = new Color(255, 127, 191, 255);
		mizu = new Color(128, 234, 255, 255);
		green = new Color(191, 255, 127, 255);
		colorBox = GameObject.Find ("colorBox");
		//Debug.Log (red);

		//gameObject.GetComponent<Renderer>().material.color = new Color(51.0f, 255.0f, 0.0f, 255.0f);

	}

	// Update is called once per frame
	void Update () {
	
		timer -= Time.deltaTime;


		if (timer <= 0.0) {
			timer = 1.0f;

			//ここに処理
			randomCount = Random.Range(0, 4);
			//Debug.Log (randomCount);

			//色表示
			gameObject.GetComponent<Renderer> ().material.color = ran[randomCount];

		}
	}

	void OnMouseDown(){

		Time.timeScale = 0;
		Debug.Log (ran[randomCount]);
		Debug.Log (randomCount);

		colorBox.gameObject.GetComponent<Renderer> ().material.color = ran[randomCount];

	}
}