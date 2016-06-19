using UnityEngine;
using System.Collections;

public class Piggy : MonoBehaviour {

	private Animator animator;
	private Attacker attacker;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		attacker = GetComponent<Attacker> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter2D(Collider2D coll){
		GameObject obj = coll.gameObject;

		if (!obj.GetComponent<Defender> ()) {
			return;
		} 
		animator.SetBool ("isAttacking", true);
		attacker.attack (obj);
	}		
}
