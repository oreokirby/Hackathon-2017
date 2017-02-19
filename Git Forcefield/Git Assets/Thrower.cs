using UnityEngine;
using System.Collections;

public class Thrower : MonoBehaviour {

	public static int Fields = 0;

	public Transform up;
	public Transform left;
	public Transform right;

	// Use this for initialization
	void Start () {

	}
		

	// Update is called once per frame
	void Update () {

		if (Fields < 3) {

			if ((Input.GetKeyDown (KeyCode.UpArrow)) || (Input.GetKeyDown ("joystick button 0"))) {
				Instantiate (left, new Vector3 (transform.position.x - 0.6f, transform.position.y, transform.position.z), Quaternion.Euler (0, 0, 90));
				Fields++;
			}
			//if ((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 1")))
				//Debug.Log ("1");
			if ((Input.GetKeyDown (KeyCode.LeftArrow)) || (Input.GetKeyDown ("joystick button 2"))) {
				Instantiate (right, new Vector3 (transform.position.x + 0.6f, transform.position.y, transform.position.z), Quaternion.Euler (0, 0, 90));
				Fields++;
			}
			if ((Input.GetKeyDown (KeyCode.RightArrow)) || (Input.GetKeyDown ("joystick button 3"))) { 
				Instantiate (up, new Vector3 (transform.position.x, transform.position.y + 0.6f, transform.position.z), Quaternion.Euler (0, 0, 0));
				Fields++;
			}
			if ((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 4")))
				Debug.Log ("4");
			if ((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 5")))
				Debug.Log ("5");
			if ((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 6")))
				Debug.Log ("6");
			if ((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 7")))
				Debug.Log ("7");
			if ((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 8")))
				Debug.Log ("8");

		}

		Debug.Log ("Forcefields: " + Fields);
	}

	void OnGUI() {
		if (Event.current.Equals (Event.KeyboardEvent ("up"))) {
			Instantiate (up, new Vector3 (transform.position.x, transform.position.y + 0.6f, transform.position.z), Quaternion.Euler (0, 0, 0));
			Fields++;
		}
	
		if (Event.current.Equals (Event.KeyboardEvent ("left"))) {
			Instantiate (left, new Vector3 (transform.position.x - 0.6f, transform.position.y, transform.position.z), Quaternion.Euler (0, 0, 90));
			Fields++;
		}

		if (Event.current.Equals (Event.KeyboardEvent ("right"))) {
			Instantiate (right, new Vector3 (transform.position.x + 0.6f, transform.position.y, transform.position.z), Quaternion.Euler (0, 0, 90));
			Fields++;
		}
			
	}
}
