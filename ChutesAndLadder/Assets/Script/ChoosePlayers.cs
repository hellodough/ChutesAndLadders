using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Colors{
	red, green, blue, yellow
};

public class ChoosePlayers : MonoBehaviour {

	/*screens*/
	public GameObject screenOne;
	public GameObject screenTwo;
	public GameObject Playbtn;

	/*colors*/
	public int numPlayers = 0;
	public int p1Color;
	public int p2Color;
	public int p3Color;
	public int p4Color;

	public GameObject red;
	public GameObject green;
	public GameObject blue;
	public GameObject yellow;

	public Text txt;

	private int curPlayer = 0;

	public void load(int num){
		Application.LoadLevel (num);
	}

	public void playerNum (int num){
		numPlayers = num;
		screenOne.SetActive (false);
		screenTwo.SetActive (true);
	}

	public void colorPick(int col){
		switch (curPlayer) {
			case 0:
				p1Color = col;
				break;
			case 1:
				p2Color = col;
				break;
			case 2:
				p3Color = col;
				break;
			case 3:
				p4Color = col;
				break;
		}
		colorDisable (col);
		curPlayer++;
		if (curPlayer == numPlayers) {
			screenTwo.SetActive(false);
			Playbtn.SetActive(true);
			return;
		}
		txt.text = "Player " + (curPlayer + 1) + " pick your color";
	}

	private void colorDisable(int col){
		switch (col) {
			case 0:
				red.SetActive(false);
				break;
			case 1:
				green.SetActive(false);
				break;
			case 2:
				blue.SetActive(false);
				break;
			case 3:
				yellow.SetActive(false);
				break;
			}
	}
}
