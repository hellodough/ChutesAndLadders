using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Online : MonoBehaviour {

	public GameObject red;
	public GameObject green;
	public GameObject blue;
	public GameObject yellow;

	public bool[] colors = new bool[4] {false, false, false, false};

	private DontDestroy dontDestroy;

	// Use this for initialization
	void Start () {
		dontDestroy = GameObject.FindGameObjectWithTag ("dontdestroy").GetComponent<DontDestroy> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PickColor(int color){
		switch (color) {
			case 0:
				red.GetComponent<Button>().interactable = false;
				green.GetComponent<Button>().interactable = true;
				blue.GetComponent<Button>().interactable = true;
				yellow.GetComponent<Button>().interactable = true;
				GameObject.FindGameObjectWithTag("cube0").renderer.material.color = Color.red;
				break;
			case 1:
				red.GetComponent<Button>().interactable = true;
				green.GetComponent<Button>().interactable = false;
				blue.GetComponent<Button>().interactable = true;
				yellow.GetComponent<Button>().interactable = true;
				GameObject.FindGameObjectWithTag("cube0").renderer.material.color = new Color(34/255.0F, 169/255.0F, 63/255.0F);
				break;
			case 2:
				blue.GetComponent<Button>().interactable = false;
				red.GetComponent<Button>().interactable = true;
				green.GetComponent<Button>().interactable = true;
				yellow.GetComponent<Button>().interactable = true;
				GameObject.FindGameObjectWithTag("cube0").renderer.material.color = Color.blue;
				break;
			case 3:
				yellow.GetComponent<Button>().interactable = false;
				red.GetComponent<Button>().interactable = true;
				green.GetComponent<Button>().interactable = true;
				blue.GetComponent<Button>().interactable = true;
				GameObject.FindGameObjectWithTag("cube0").renderer.material.color = new Color(255/255.0F, 228/255.0F, 34/255.0F);
				break;
		}
	}

	public void ColorPick(int col){
		colors[col] = true;
		dontDestroy.p1Color = col;
		dontDestroy.human[0] = true;
		for (int i = 0; i < 4; i++) {
			if(i != col){
				colors[i] = false;
			}
		}
	}

	public void designateComps(int num) {
		while (num > 0) {
			for (int i = 0; i < 4; i++) {
				if (colors[i] == false) {
					if (dontDestroy.p2Color == -1) {
						dontDestroy.p2Color = i;
					} else if (dontDestroy.p3Color == -1) {
						dontDestroy.p3Color = i;
					} else if (dontDestroy.p4Color == -1) {
						dontDestroy.p4Color = i;
					}
					colors[i] = true;
					break;
				}
			}
//			dontDestroy.numPlayers++;
			num--;
		}
		dontDestroy.numPlayers = 4;
		Application.LoadLevel ("Board");
	}
}
