using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed, damage = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider){
		GameObject obj = collider.gameObject;

		if (obj.GetComponent<Attacker> () && obj.GetComponent<Health>()) {
			obj.GetComponent<Health> ().dealDamage (damage);
			Destroy (gameObject);
		}
	}
		
}
