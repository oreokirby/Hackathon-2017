using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour {

	private Vector3 moveVector;
	private Vector3 lastMove;
	public float speed = 8;
	public float jumpforce = 8;
	public float gravity = 25;
	public float senseH = 9.0f;
	private float verticalVelocity = 0f;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {

		// Point the object in the direction of the mouse
		transform.Rotate(0, Input.GetAxis ("Mouse X") * senseH, 0);

		moveVector = Vector3.zero;
		moveVector.x = Input.GetAxis ("Horizontal");
		moveVector.z = Input.GetAxis ("Vertical");

		if (controller.isGrounded) {
			verticalVelocity = -1;

			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Space)) {
				verticalVelocity = jumpforce;
			}
		}

		else {
			verticalVelocity -= gravity * Time.deltaTime;
			moveVector = lastMove;
		}
			
		moveVector.y = 0;
		moveVector.Normalize ();
		moveVector *= speed;
		moveVector.y = verticalVelocity;

		controller.Move (moveVector * Time.deltaTime);
		lastMove = moveVector;
	}
}