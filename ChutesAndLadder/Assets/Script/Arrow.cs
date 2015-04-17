using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public int value;
	public Driver driver;
	public DontDestroy dontDestroy;

	private bool set = false;
	private float usage;

	private int jVal;

	private bool animate = false;
	private Quaternion first;
	private float lerpTime = .75f;
	private float curLerpTime;
	private float speed = .5f;

	private bool setTime = false;
	private float usageTime;

	// Use this for initialization
	void Start () {
		value = 1;
		driver = GameObject.FindGameObjectWithTag ("driver").GetComponent<Driver> ();
		dontDestroy = GameObject.FindGameObjectWithTag ("dontdestroy").GetComponent<DontDestroy> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (dontDestroy.human [driver.playerTurn-1] == false) {
			if(!set){
				usage = Time.time + 2f;
				set = true;
			}
			if(Time.time > usage){
				OnMouseDown();		
				set = false;
			}
		}

		if (animate) {
			spin();		
		}
	}

	void OnMouseDown(){
		if(!driver.animating){
			first = transform.rotation;
			Vector3 rotate = Quaternion.Euler (0, 0, 0) * Vector3.forward;

			int rand = Random.Range (1, 6);
			jVal = 360-(60 * rand);

			value = ((value + rand) % 6);
			if (value == 0)
				value = 6;

			print (value);

			switch (driver.playerTurn) {
				case 1:
					GameObject.FindGameObjectWithTag ("Player1").GetComponent<PlayerMovement> ().move = true;
					GameObject.FindGameObjectWithTag ("Player1").GetComponent<PlayerMovement> ().spacesToMove = value;
					break;
				case 2:
					GameObject.FindGameObjectWithTag ("Player2").GetComponent<PlayerMovement> ().move = true;
					GameObject.FindGameObjectWithTag ("Player2").GetComponent<PlayerMovement> ().spacesToMove = value;
					break;
				case 3:
					GameObject.FindGameObjectWithTag ("Player3").GetComponent<PlayerMovement> ().move = true;
					GameObject.FindGameObjectWithTag ("Player3").GetComponent<PlayerMovement> ().spacesToMove = value;
					break;
				case 4: 
					GameObject.FindGameObjectWithTag ("Player4").GetComponent<PlayerMovement> ().move = true;
					GameObject.FindGameObjectWithTag ("Player4").GetComponent<PlayerMovement> ().spacesToMove = value;
					break;
	//			default:
	//				break;
			}
			driver.playerTurn = (driver.playerTurn % dontDestroy.numPlayers) + 1;
//			setTime = false;
//			int i = 0;
//			while(i<jVal){
//				if(!setTime){
//					print ("set time");
//					setTime = true;
//					transform.Rotate (rotate);
//					usageTime = Time.time + 1f;
//				}
//				if(Time.time > usageTime){
//					i++;
//					print ("time's up!");
//					setTime = false;
//				}
//			}
//			Quaternion temp = transform.rotation;
//			temp.z = transform.rotation.z * jVal;
//			transform.rotation = temp;
//
			//animate = true;

			for(int i = 0; i < jVal; i++)
				transform.Rotate(rotate);
		}
	}

	public void spin(){
//		curLerpTime += Time.deltaTime * speed;
//		print ("spin");
//		if (curLerpTime > lerpTime) {
//			animate = false;
//			curLerpTime = 0;
//		}
//		float perc = curLerpTime / lerpTime;
//	
//
//		Quaternion.Lerp(first, transform.rotation, perc);
	}
}
