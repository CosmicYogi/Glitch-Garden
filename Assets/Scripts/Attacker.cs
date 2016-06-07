using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

	//[Range (-1.5f,2f)] //Add this block above declaration to range it's value.
	//Earlier this currentSpeed variable was public to check what speed would be best, now privatized.
	private float currentSPeed;
	private GameObject currentTarget;
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

	public void strikeCurrentTarget(float damage){
		print (name + ",damaged amount " + damage);
	}

	public void attack(GameObject obj){
		currentTarget = obj;
	}
}
