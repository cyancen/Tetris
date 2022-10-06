using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public static int gridWidth = 10;
	public static int gridHeight = 20;




	void Start () {
	
	}
	
	void Update () {
	
	}


	public bool CheckInsideGrid (Vector2 pos) {
		return ((int)pos.x >=0 && (int)pos.x < gridWidth && (int)pos.y >=0);
	}

	public Vector2 Round (Vector2 pos) {
		return new Vector2 (Mathf.Round(pos.x), Mathf.Round(pos.y));
	}


}
