using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public int value;
	public Driver driver;
	public DontDestroy dontDestroy;

	private bool set = false;
	private float usage;

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
	}

	void OnMouseDown(){
		if(!driver.animating){
			Vector3 rotate = Quaternion.Euler (0, 0, 0) * Vector3.forward;

			int rand = Random.Range (1, 6);
			int j = 360-(60 * rand);

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

			for(int i=0; i<j; i++)
				transform.Rotate (rotate);
		
		}
	}
}
