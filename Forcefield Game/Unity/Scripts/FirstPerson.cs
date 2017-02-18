using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour {

	public float speed = 6.0f;
	public float gravity = -40;
	public float senseH = 9.0f;

	// Allows the move method to be called
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {

		// Point the object in the direction of the mouse
		transform.Rotate(0, Input.GetAxis ("Mouse X") * senseH, 0);

		// Use the built in scripts to use the arrow keys
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);

		// Move in the direction indicated by the arrow keys.
		movement = Vector3.ClampMagnitude (movement, speed);
		movement.y = gravity;
		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		controller.Move(movement);

	}
}