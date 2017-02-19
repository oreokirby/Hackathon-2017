using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public Transform bullet;

	private float time;
	private float interval;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		time += 2 * Time.deltaTime;

		if (time > interval) {
			Instantiate (bullet, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler (0, 0, 90));
			interval = time + 5;
		}

		//Debug.Log ("time=" + time);
		//Debug.Log ("interval=" + interval);
	}

}
