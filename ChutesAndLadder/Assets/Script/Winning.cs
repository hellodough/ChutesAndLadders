using UnityEngine;
using System.Collections;

public class Winning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int winner = GameObject.FindGameObjectWithTag("dontdestroy").GetComponent<DontDestroy>().winner;
		GetComponent<GUIText> ().text = "Player " + winner + " wins!";
	}
}
