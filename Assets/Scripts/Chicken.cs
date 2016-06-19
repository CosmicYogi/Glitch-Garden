using UnityEngine;
using System.Collections;

public class Chicken : MonoBehaviour {

	private Animator animator;
	private Attacker attacker;
	// Use this for initialization
	void Start () {
		attacker = GetComponent<Attacker> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		GameObject obj = coll.gameObject;

		if (!obj.GetComponent<Defender> ()) {
			return;
		}
		animator.SetBool ("isAttacking", true);
		attacker.attack (obj);
	}
}
