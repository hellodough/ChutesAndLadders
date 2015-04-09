using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float max; 
	private float min;

	// Use this for initialization
	void Start () {
		max = 9;
		min = 0;
		MoveSpaces (4f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void MoveSpaces(float spaces){
		Vector3 temp = transform.localPosition;
		print ("temp " + temp);
		float xSpots = temp.x + spaces;
		float ySpots = 0;

		//even rows move right
		//odd rows move left
		if (temp.y % 2 == 0) {
			print ("even");
			if (xSpots > max) {
				temp.x = max;
				ySpots++;
				spaces -= (max - temp.x) ;
				print ("spaces" + spaces);
			}
			else{
				temp.x += xSpots;
				spaces -= xSpots;
			}
		}
		else{
			print ("odd");
			if (xSpots > max) {
				temp.x = min;
				spaces -= (temp.x - min); //fix this
				ySpots++;
			}
			else{
				temp.x -= xSpots;
				spaces -= xSpots;
			}
		}
		//move up if needed
		temp.y += ySpots;
		spaces -= ySpots;
		print ("spaces left " + spaces);
//		//finish off x movements
//		if (ySpots > 0) {
//			if (temp.y % 2 == 0) {
//				print ("even spaces " + spaces);
//				temp.x += spaces;
//				spaces -= spaces;
//			}
//			else{
//				print ("odd spaces " + spaces);
//				temp.x -= spaces;
//				spaces -= spaces;
//			}
//		}
		transform.localPosition = temp;
	}
}
