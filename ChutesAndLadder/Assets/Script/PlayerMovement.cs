﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	
	private float max; 
	private float min;
	private int curSpace;
	
	// Use this for initialization
	void Start () {
		max = 9;
		min = 0;
		curSpace = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void MoveSpaces(int spaces){
		if (curSpace + spaces > 100) {
			print ("over 100");
			return;		
		}
		curSpace += spaces;
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
		curSpace = chutesAndLadders (curSpace);
		curPos = spacesToCoord (curSpace);
//		//space to coord
		print ("cur space " + curSpace);
		transform.localPosition = curPos;
		if(curSpace == 100){
			print ("winner!");
		}
	}

	private int chutesAndLadders(int curSpace){
		switch (curSpace) {
			case 1:
				return 38;
			case 4:
				return 14;
			case 9:
				return 31;
			case 16:
				return 6;
			case 21:
				return 42;
			case 28:
				return 84;
			case 36:
				return 44;
			case 48:
				return 26;
			case 49:
				return 11;
			case 51:
				return 67;
			case 56:
				return 53;
			case 62:
				return 19;
			case 64:
				return 60;
			case 71:
				return 91;
			case 80:
				return 100;
			case 87:
				return 24;
			case 93:
				return 73;
			case 95:
				return 75;
			case 98:
				return 78;
			default:
				break;
			}
		return curSpace;
	}

	private Vector3 spacesToCoord(int spaces){
		int y;
		int x;
		y = (int)((spaces - 1) / 10);
		if (y % 2 == 0) {
			x = ((spaces ) % 10) - 1;
			if((spaces % 10) == 0){
				x = 9;
			}
		}
		else{
			x = 10 - (spaces % 10);
			if((spaces % 10) == 0){
				x = 0;
			}
		}
		print ("y " + y);
		return new Vector3 (x, y, 0);
	}
}
