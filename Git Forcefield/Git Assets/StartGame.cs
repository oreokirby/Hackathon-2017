using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void changeToScene(int test3){

		SceneManager.LoadScene (test3);
	}
}
