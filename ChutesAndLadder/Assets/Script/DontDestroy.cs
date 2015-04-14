using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	private static DontDestroy instance;
	public int numPlayers;

	public int p1Color = -1;
	public int p2Color = -1;
	public int p3Color = -1;
	public int p4Color = -1;

	public bool[] human = new bool[4] {false, false, false, false};

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
