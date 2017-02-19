using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceColor : MonoBehaviour {

	private float R = 0f;
	private float G = 0.9f;
	private float B = 1f;
	private float alpha = 0.6f;

	// Use this for initialization
	void Start () {
		Color newColor = new Color( R, G, B, alpha );
		GetComponent<Renderer> ().material.color = newColor; 
	}

	// Update is called once per frame
	void Update () {

		if (R >= 1f) {
			G -= 0.3f * Time.deltaTime;
			B -= 0.3f * Time.deltaTime;
			if (alpha > 0)
			alpha -= 0.3f * Time.deltaTime;
		}

		if (R <= 0.30f) {
			R += 0.08f * Time.deltaTime;
		}
		else 
			R += 0.6f * Time.deltaTime;

		Color newColor = new Color( R, G, B, alpha );
		GetComponent<Renderer> ().material.color = newColor; 

		//Debug.Log ("R=" + R);
		//Debug.Log ("G=" + G);
		//Debug.Log ("B=" + B);
		//Debug.Log ("alpha=" + alpha);

		if (alpha < 0.1) {
			Destroy (this.gameObject);
			Thrower.Fields --;
		}
	}
}
