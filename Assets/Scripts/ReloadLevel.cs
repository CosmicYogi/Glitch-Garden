using UnityEngine;
using System.Collections;

public class ReloadLevel : MonoBehaviour {

	private LevelManager lm;
	// Use this for initialization
	void Start () {
		lm = GameObject.FindObjectOfType<LevelManager> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		lm.GetComponent<LevelManager> ().LoadCurrentLevel ();
	}
}
