using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour {

	float fall = 0;
	public float fallSpeed = 1;
	public bool allowRotation = true;
	public bool limitRotation = false;


	void Start () {
	
	}
	
	void Update () {
		CheckUserInput();
	}

	void CheckUserInput () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.position += new Vector3(1,0,0);
			if (CheckIsValidPosition()) {

			} else {
				transform.position += new Vector3(-1,0,0);
			}

		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) 
		{
			transform.position += new Vector3(-1,0,0);
			if (CheckIsValidPosition()) {

			} else {
				transform.position += new Vector3(1,0,0);
			}
		}
		 else if (Input.GetKeyDown(KeyCode.Space))
		{ 
			 transform.Rotate (0,0,90);
			 if (CheckIsValidPosition()) {

			 } else {
				 transform.Rotate (0,0,-90);
			 }
		}
		 else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - fall >= fallSpeed) 
		{
			transform.position += new Vector3(0,-1,0);

			fall = Time.time;

			if (CheckIsValidPosition()) {

			} else {
				transform.position += new Vector3(0,1,0);
			}
		}
	}

	bool CheckIsValidPosition () {
		foreach (Transform box in transform) {
			Vector2 pos = FindObjectOfType<Game>().Round (box.position);

			if (FindObjectOfType<Game>().CheckInsideGrid (pos) == false) {
				return false;
			} 
		}
		return true;
	}	



}
