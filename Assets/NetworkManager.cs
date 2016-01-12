using UnityEngine;
using System.Collections;

public class NetworkManager : Photon.MonoBehaviour {
	void Awake () {
		// Server接続
		PhotonNetwork.ConnectUsingSettings("v0.1");
	}
	// Lobby参加OK時
	void OnJoinedLobby() {
		// ランダムにRoom参加
		PhotonNetwork.JoinRandomRoom();
	}
	// Room参加NG時
	void OnPhotonRandomJoinFailed() {
		Debug.Log("Room参加失敗！");
		// 名前なしRoom作成
		PhotonNetwork.CreateRoom(null);
	}
	// Room参加OK時
	void OnJoinedRoom() {
		Debug.Log("Room参加成功！");
		//プレイヤーをインスタンス化
//			Vector3 spawnPosition = new Vector3 (Random.Range (-2, 2), 5, 0); //生成位置
//			var go = PhotonNetwork.Instantiate ("Hanabi", spawnPosition, Quaternion.identity, 0);

//		Vector3 spawnPosition = new Vector3 (Random.Range (-2, 2), 5, 0); //生成位置
//		var go = PhotonNetwork.Instantiate ("Hanabi", spawnPosition, Quaternion.identity, 0);

	}

	// GUI表示
	void OnGUI() {
		// Photon接続状態
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
	}
}