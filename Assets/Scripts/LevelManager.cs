using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public bool autoLoadNextLevel = false;
	public float splashDelay = 5;
	// Use this for initialization
	void Start () {
		if (autoLoadNextLevel == true) {
			if (splashDelay <= 0) {
				Debug.Log ("Please put a positive number in SplashDelay in seconds");
			} else {
				Invoke ("LoadNextLevel", splashDelay);
			}
		}
	}

	void Update(){
			if (Input.GetKeyDown(KeyCode.Escape)){
			if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "01a Start") {
				Application.Quit();
			} else {
				LoadLevel ("01a Start");
			}
		}
	}
	public void LoadNextLevel(){
		UnityEngine.SceneManagement.SceneManager.LoadScene 
			(UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex + 1);
	}
	public void LoadLevel(string level){
		UnityEngine.SceneManagement.SceneManager.LoadScene (level);
	}
	public void QuitRequest(){
		Debug.Log ("Quit Requested");
		Application.Quit ();
	}
	public void LoadCurrentLevel(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name);
		print ("Load current Level() called");
	}
}
