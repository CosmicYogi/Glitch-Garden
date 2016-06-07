using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]
public class Fox : MonoBehaviour {

	private Attacker attacker;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		attacker = GetComponent<Attacker> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		GameObject obj = coll.gameObject;

		//Do nothing if not colliding with Defender.
		if (!obj.GetComponent<Defender> ()) {
			return;
		}

		if (obj.GetComponent<Stone> ()) {
			anim.SetTrigger ("jumpTrigger");
		} else {
			anim.SetBool ("isAttacking", true);
			attacker.attack (obj);
		}
		print ("Fox Collided with " + coll);
	}
}
