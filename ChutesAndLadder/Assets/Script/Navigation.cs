using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject nextButton;
	public GameObject backButton;
	public GameObject menuButton;
	public GameObject playButton;

	private int counter;

	void Start(){
		counter = 0;
	}

	public void back(){
		switch(counter){
			case 0:
				break;
			case 1:
				backButton.SetActive(false);
				text2.SetActive(false);
				text1.SetActive(true);
				break;
			case 2:
				text3.SetActive(false);
				text2.SetActive(true);
				break;
			case 3:
				text4.SetActive(false);
				text3.SetActive(true);
				break;
			case 4:
				text5.SetActive(false);
				text4.SetActive(true);
				nextButton.SetActive(true);
				playButton.SetActive(false);
				break;
		}
		counter--;
	}

	public void next(){
		print ("next button");
		switch (counter) {
			case 0:
				backButton.SetActive(true);
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
				nextButton.SetActive(false);
				playButton.SetActive(true);
				break;
			}
		counter++;
	}

	public void loadMenu(int scene){
		Application.LoadLevel(scene);
	}
}
