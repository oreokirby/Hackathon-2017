using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour {

	private float count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {

		count += 1f * Time.deltaTime;

		Debug.Log ("count=" + count);

		if (count > 0.5)
			Destroy(this.gameObject);

	}
}
