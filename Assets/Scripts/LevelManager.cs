using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float splashDelay = 5;
	// Use this for initialization
	void Start () {
		Invoke ("LoadNextLevel", splashDelay);
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
}
