using UnityEngine;
using System.Collections;

public class Loose : MonoBehaviour {

	private int counter = 0;
	public int maxLooseCount =10;
	private LevelManager lm;
	// Use this for initialization
	void Start () {
		lm = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		Destroy (collider.gameObject);
		counter += 1;
		if (counter >= maxLooseCount) {
			print ("You Loose");
			lm.LoadLevel ("03b Loose");
		}

	}
}
