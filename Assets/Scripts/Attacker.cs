using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (-1.5f,2f)] //Add this block above declaration to range it's value.
	public float currentSPeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector2.left * currentSPeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(){
		print (name + "Trigger Enter");
	}

	void setCurrentSpeed(float speed){
		currentSPeed = speed;
	}

	void strikeCurrentTarget(float damage){
		print (name + ",damaged amount " + damage);
	}
}
