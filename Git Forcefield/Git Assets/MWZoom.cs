using UnityEngine;
using System.Collections;

public class MWZoom : MonoBehaviour {

	float cameraDistanceMax = 20f;
	float cameraDistanceMin = 5f;
	float cameraDistance = 10f;
	float scrollSpeed = 0.5f;

	void Update()
	{
		cameraDistance += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
		cameraDistance = Mathf.Clamp(cameraDistance, cameraDistanceMin, cameraDistanceMax);

		// set camera position
	}
}