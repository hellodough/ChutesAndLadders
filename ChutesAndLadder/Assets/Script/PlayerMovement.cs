using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	
	private float max; 
	private float min;
	
	// Use this for initialization
	void Start () {
		max = 9;
		min = 0;
		MoveSpaces (12f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void MoveSpaces(float spaces){
		Vector3 curPos = transform.localPosition;
		bool right = (curPos.y % 2 == 0);
		float distX = 0;
		float nextX = 0;
		if (right) {
			print ("even row");
			distX = max - curPos.x;
			if(spaces > distX){
				print ("reached right bound " + distX);
				nextX = spaces - distX;
				curPos.x = max - (nextX - 1);
				curPos.y++;
			}
			else{
				curPos.x += spaces;
			}
		}
		else{
			distX = curPos.x - min;
			if(spaces > distX){
				print ("reached left bound");
				nextX = spaces - distX;
				curPos.x = nextX - 1;
				curPos.y++;
			}
			else{
				curPos.x -= spaces;
			}
		}
		transform.localPosition = curPos;
	}
}
