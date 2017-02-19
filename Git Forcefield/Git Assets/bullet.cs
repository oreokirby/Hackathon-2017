using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	float posx;
	private bool reflect;

	// Use this for initialization
	void Start () {
		posx = transform.position.x;
		reflect = false;
	}

	// Update is called once per frame
	void Update () {

		if (!(reflect)) {
			if (transform.position.x > posx - 10) {
				Vector3 delta = new Vector3 (-0.1f, 0, 0);
				transform.position += delta;
			} else
				Destroy (this.gameObject);
		} 

		else {
			if (transform.position.x < posx + 10) {
				Vector3 delta = new Vector3 (0.1f, 0, 0);
				transform.position += delta;
			} else
				Destroy (this.gameObject);
		
		}
	}



	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Forcefield") { 

			// If so, remove it from the game and increase Robot size and speed.
			if (reflect){
				reflect = false;
				return;
			}

			if (!(reflect)) {
				reflect = true;
				return;
			}
		}

		// Make sure it is actually the target
		if (other.gameObject.tag == "Player") { 

			// If so, remove it from the game and destroy treasure to stop camera movement.
			Destroy (other.gameObject);
		}
	}

}
