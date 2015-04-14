using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	private static DontDestroy instance;
	public int numPlayers;

	public int p1Color;
	public int p2Color;
	public int p3Color;
	public int p4Color;


	public static DontDestroy Instance{
		get{return instance;}
	}
	
	void Awake() {
		DontDestroyOnLoad(this);

		if (instance == null)
			instance = this;
		else if (instance != this) {
			Destroy(gameObject);
			return;
		}
	}
}
