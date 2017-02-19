using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceLeft : MonoBehaviour {

	float posx;

	// Use this for initialization
	void Start () {
		posx = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.localScale.x < 6)
		transform.localScale += new Vector3(0.35f, 0, 0.35f);

		if (transform.position.x > posx-3) {
			Vector3 delta = new Vector3 (-0.2f, 0, 0);
			transform.position += delta;
		}

	}
}
