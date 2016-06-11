using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

	//[Range (-1.5f,2f)] //Add this block above declaration to range it's value.
	//Earlier this currentSpeed variable was public to check what speed would be best, now privatized.
	private float currentSPeed;
	private GameObject currentTarget;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector2.left * currentSPeed * Time.deltaTime);
		if (currentTarget == null) {
			anim.SetBool ("isAttacking", false);
		}
	}

	void OnTriggerEnter2D(){
		//print (name + "Trigger Enter");
	}

	void setCurrentSpeed(float speed){
		currentSPeed = speed;
	}

	public void strikeCurrentTarget(float damage){
		//print (name + ",damaged amount " + damage);
		currentTarget.GetComponent<Health> ().dealDamage (damage);
	}

	public void attack(GameObject obj){
		currentTarget = obj;
	}
}
