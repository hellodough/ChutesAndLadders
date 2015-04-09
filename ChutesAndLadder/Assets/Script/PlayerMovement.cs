using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private int max; 
	private int min;

	// Use this for initialization
	void Start () {
		max = 9;
		min = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoveSpaces(int spaces){
		Vector3 temp = transform.position;
		//even rows move right
		//odd rows move left
		if (temp.y % 2 == 0) {
					
		}
		else{
		
		}


	}
}
