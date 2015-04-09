using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public int value;

	// Use this for initialization
	void Start () {
		value = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		
		Vector3 rotate = Quaternion.Euler (0, 0, 0) * Vector3.forward;

		int rand = Random.Range (1, 6);
		int j = 360-(60 * rand);

		value = ((value + rand) % 6);
		if (value == 0)
			value = 6;

		print (value);

		for(int i=0; i<j; i++)
			transform.Rotate (rotate);
		
	}
}
