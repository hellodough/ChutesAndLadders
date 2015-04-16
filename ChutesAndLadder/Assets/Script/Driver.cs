using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {

	public int playerTurn;	
	public bool animating = false;

	// Use this for initialization
	void Start () {
		playerTurn = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.FindGameObjectWithTag ("turntext").GetComponent<GUIText> ().text = "Player " + playerTurn + "'s turn!";
	}
}
