using UnityEngine;
using System.Collections;

public class GameCode : MonoBehaviour
{
	private socketScript _mySocket;
	private TCPConnection _myTCP;
	private GameObject gameUI;
	private GameObject preGameUI;
	// Use this for initialization
	void Start ()
	{
		_mySocket = gameObject.GetComponent<socketScript> ();
		_myTCP = GameObject.Find ("NetworkCode").GetComponent<TCPConnection> ();
		gameUI = GameObject.Find ("gameUI");
		preGameUI = GameObject.Find ("preGameUI");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (_myTCP.socketReady) {
			gameUI.SetActive (true);
			preGameUI.SetActive (false);
		} else {
			gameUI.SetActive (false);
			preGameUI.SetActive (true);
		}
	}
	public void Restart ()
	{
		//_mySocket.SendToServer ("COMMAND_RESTART");
		_mySocket.SendToServer ("-1");

	}
}
