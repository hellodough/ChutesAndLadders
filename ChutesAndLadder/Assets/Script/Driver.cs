using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {

	public int playerTurn;	
	public bool animating = false;

	// Use this for initialization
	void Start () {
		playerTurn = 1;
	updateTurn();
	}
	
	// Update is called once per frame
	public void Update () {
		//if (!animating)
		//	GameObject.FindGameObjectWithTag ("turntext").GetComponent<GUIText> ().text = "Player " + playerTurn + "'s turn!";
	}

	public void updateTurn(){
		GameObject.FindGameObjectWithTag ("turntext").GetComponent<GUIText> ().text = "Player " + playerTurn + "'s turn!";
	}
}
