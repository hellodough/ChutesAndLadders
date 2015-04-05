using UnityEngine;
using System.Collections;

public class NextInstruction : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject btn;

	private int counter;

	void Start(){
		counter = 0;
		text1.SetActive (true);
	}

	public void next(){
		switch (counter) {
			case 0:
				text1.SetActive(false);
				text2.SetActive(true);
				break;
			case 1:
				text2.SetActive(false);
				text3.SetActive(true);
				break;
			case 2:
				text3.SetActive(false);
				text4.SetActive(true);
				break;
			case 3:
				text4.SetActive(false);
				text5.SetActive(true);
				btn.SetActive(false);
				break;
			}
		counter++;
	}

	public void loadMenu(){
		Application.LoadLevel (0);
	}
}
