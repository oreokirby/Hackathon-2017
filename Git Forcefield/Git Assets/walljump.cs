using UnityEngine;
using System.Collections;

public class walljump : MonoBehaviour {

	private Vector3 moveVector;
	private Vector3 lastMove;
	public float speed = 10;
	public float jumpforce = 15;
	public float gravity = 25;
	public float senseH = 9.0f;
	private float yaw = 0.0f;
	private float pitch = 0.0f;
	private float verticalVelocity;
	private CharacterController controller;

	public Transform dust;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {

		// Point the object in the direction of the mouse
		//transform.Rotate(0, Input.GetAxis ("Mouse X") * senseH, 0);

		yaw += senseH * Input.GetAxis ("Mouse X");
		pitch -= senseH * Input.GetAxis ("Mouse Y");

		//transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);

		moveVector = Vector3.zero;
		moveVector.x = Input.GetAxis ("Horizontal");
		moveVector.z = Input.GetAxis ("Vertical");

		if (controller.isGrounded) {
			verticalVelocity = -1;

			if ((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 1"))) {
				verticalVelocity = jumpforce;

				//if (InputManager.AButton ())
				//	verticalVelocity = jumpforce;
			}
		}

		else {
			verticalVelocity -= gravity * Time.deltaTime;

			moveVector = lastMove;
		}
			
		moveVector.y = 0;
		if (!(controller.isGrounded))
		moveVector.Normalize ();
		moveVector *= speed;
		moveVector.y = verticalVelocity;
		if (controller.isGrounded)
		moveVector = transform.TransformDirection (moveVector);
		controller.Move (moveVector * Time.deltaTime);
		lastMove = moveVector;
	}

	private void OnControllerColliderHit (ControllerColliderHit hit)
	{
		if(!controller.isGrounded && hit.normal.y < 0.1f && (!(hit.gameObject.tag == "Wall")))
		{
			if ((hit.gameObject.tag != "Wall") || (hit.gameObject.tag != "Forcefield"))
			Instantiate(dust, transform.position, Quaternion.identity);

			if((Input.GetKeyDown (KeyCode.Space)) || (Input.GetKeyDown ("joystick button 1")))
			{
				//Debug.DrawRay(hit.point,hit.normal,Color.red,10.25f);
				verticalVelocity = jumpforce;
				moveVector = hit.normal * speed;
			}
		}
	}
}