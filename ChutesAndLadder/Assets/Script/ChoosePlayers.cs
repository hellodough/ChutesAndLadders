using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Colors{
	red, green, blue, yellow
};


public class ChoosePlayers : MonoBehaviour {

	public const int MAXPLAYERS = 4;
	/*screens*/
	public GameObject playerSelect;
	public GameObject colorSelect;

	public GameObject numPlayersText;
	public GameObject computersText;
	public GameObject numCompText;
	
	public GameObject playButton;
	public GameObject yesButton;
	public GameObject noButton;

	public GameObject oneComp;
	public GameObject twoComp;
	public GameObject threeComp;

//	/*colors*/
//	public int numPlayers = 0;
//	public int p1Color;
//	public int p2Color;
//	public int p3Color;
//	public int p4Color;

	public GameObject red;
	public GameObject green;
	public GameObject blue;
	public GameObject yellow;

	public Text txt;

	private int curPlayer = 0;
	// index 0: red
	// index 1: green
	// index 2: blue
	// index 3: yellow
	private bool[] colors = new bool[4] {false, false, false, false};

	private DontDestroy dontDestroy;

	void Start(){
		dontDestroy = GameObject.FindGameObjectWithTag ("dontdestroy").GetComponent<DontDestroy> ();
	}

	public void load(int num){
		Application.LoadLevel(num);
	}

	public void playerNum(int num){
		dontDestroy.numPlayers = num;

		numPlayersText.SetActive(false);
		playerSelect.SetActive(false);
		colorSelect.SetActive(true);
	}

	public void colorPick(int col){
		switch (curPlayer) {
			case 0:
				dontDestroy.p1Color = col;
				break;
			case 1:
				dontDestroy.p2Color = col;
				break;
			case 2:
				dontDestroy.p3Color = col;
				break;
			case 3:
				dontDestroy.p4Color = col;
				break;
		}
		colorDisable(col);
		curPlayer++;
		if (curPlayer == dontDestroy.numPlayers) {
			colorSelect.SetActive(false);
			if (dontDestroy.numPlayers < MAXPLAYERS) {
				numPlayersText.SetActive(false);
				computersText.SetActive(true);
				yesButton.SetActive(true);
				noButton.SetActive(true);
			} else {
				playButton.SetActive(true);
			}
			return;
		}
		txt.text = "Player " + (curPlayer + 1) + ", pick your color";
	}

	public void chooseComputers(bool yes) {
		int possibleComps = MAXPLAYERS - dontDestroy.numPlayers;
		colorSelect.SetActive(false);
		yesButton.SetActive(false);
		noButton.SetActive(false);
		computersText.SetActive(false);
		if (!yes) {
			playButton.SetActive(true);
			return;
		} 
		// if only one computer needed, go straight to game
		if (possibleComps == 1) {
			playButton.SetActive(true);
		} else {
			numCompText.SetActive(true);
			oneComp.SetActive(true);
			twoComp.SetActive(true);
			threeComp.SetActive(true);
			if (possibleComps < 3) {
				threeComp.SetActive(false);
			} else if (possibleComps < 2) {
				twoComp.SetActive(false);
			}
		}
	}

	public void designateComps(int num) {
		if (num == 1) {
			for (int i = 0; i < 4; i++) {
				if (colors[i] == false) {
					dontDestroy.c1Color = i;
					colors[i] = true;
					break;
				}
			}
		}
	}

	private void colorDisable(int col){
		switch (col) {
			case 0:
				red.GetComponent<Button>().interactable = false;
				colors[0] = true;
				break;
			case 1:
				green.GetComponent<Button>().interactable = false;
				colors[1] = true;
				break;
			case 2:
				blue.GetComponent<Button>().interactable = false;
				colors[2] = true;
				break;
			case 3:
				yellow.GetComponent<Button>().interactable = false;
				colors[3] = true;
				break;
			}
	}



}