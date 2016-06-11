using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject projectileParent;
	public GameObject gun;

	// Use this for initialization
	void Start () {
		projectileParent = GameObject.Find ("Projectile");

		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void fireGun(){
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gun.transform.position; 
	}
}
