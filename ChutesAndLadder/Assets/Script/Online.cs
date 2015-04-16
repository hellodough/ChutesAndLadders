using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Online : MonoBehaviour {

	public GameObject red;
	public GameObject green;
	public GameObject blue;
	public GameObject yellow;

	// Use this for initialization
	void Start () {
	
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
				break;
			case 1:
				red.GetComponent<Button>().interactable = true;
				green.GetComponent<Button>().interactable = false;
				blue.GetComponent<Button>().interactable = true;
				yellow.GetComponent<Button>().interactable = true;
				break;
			case 2:
				blue.GetComponent<Button>().interactable = false;
				red.GetComponent<Button>().interactable = true;
				green.GetComponent<Button>().interactable = true;
				yellow.GetComponent<Button>().interactable = true;
				break;
			case 3:
				yellow.GetComponent<Button>().interactable = false;
				red.GetComponent<Button>().interactable = true;
				green.GetComponent<Button>().interactable = true;
				blue.GetComponent<Button>().interactable = true;
				break;
		}
	}
}
