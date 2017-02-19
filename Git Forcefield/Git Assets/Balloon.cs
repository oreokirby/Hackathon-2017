using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {

	// Amount to move along x and z axes on each frame
	private Vector3 movement;
	public float speed;

	// Use this for initialization
	void Start () {
		// Convert direction I am facing into an amount to move
		// along the x and z axes

		// Get the angle (in degrees) I am facing around the y axis
		float angleInDegrees = transform.rotation.eulerAngles.y;

		// Convert to radians for trig
		float angleInRadians = angleInDegrees * Mathf.Deg2Rad;

		// Use trig functions to convert angle to amount to move in
		// z and x directions
		float dz = Mathf.Cos (angleInRadians);
		float dx = Mathf.Sin (angleInRadians);

		// Convert to Vector3
		movement = new Vector3 (dx, 0, dz);

		// Normalize by speed
		movement = Vector3.ClampMagnitude(movement, 1) * speed;
	}
	
	// Update is called once per frame
	void Update () {
		// Move by the amount determined at the start
		transform.position += movement;
		// GameObject.Destroy (this.gameObject);


	}
}
