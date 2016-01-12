using UnityEngine;
using System.Collections;

public class TekitoScript : Photon.MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (photonView.isMine) {
//			// [FixedUpdateソース中身]
//
//			if (Input.GetKeyDown(KeyCode.Space)) {
//				transform.position += new Vector3 (0f, transform.position.y + 0.1f, 0f);
//				Vector3 spawnPosition = new Vector3 (Random.Range (-2, 2), 5, 0); //生成位置
//				var go = PhotonNetwork.Instantiate ("Hanabi", spawnPosition, Quaternion.identity, 0);
//			}
//		}
//	
	}

	public void shiro(){
		Debug.Log ("shiro66");
		if (photonView.isMine) {
			// [FixedUpdateソース中身]

			Vector3 spawnPosition = new Vector3 (Random.Range (-2, 2), 5, 0); //生成位置
			var go = PhotonNetwork.Instantiate ("Hanabi", spawnPosition, Quaternion.identity, 0);
			Debug.Log ("shiro");
		}
	}
}
