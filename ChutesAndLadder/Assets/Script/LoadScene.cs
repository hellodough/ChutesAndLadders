using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void navigate(int scene){
		Application.LoadLevel(scene);
	}
}
