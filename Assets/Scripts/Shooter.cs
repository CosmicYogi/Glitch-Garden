using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject projectileParent;
	public GameObject gun;

	private Animator animator;
	private Spawner myLaneSpawner;

	// Use this for initialization
	void Start () {
		setMyLaneSpawner ();
		print (myLaneSpawner);
		animator = GameObject.FindObjectOfType<Animator> ();

		projectileParent = GameObject.Find ("Projectile");
		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (isAttackerAheadInLane() == true){
			animator.SetBool("isAttacking",true);
		}
		else{
			animator.SetBool("isAttacking",false);
		}
	}

	bool isAttackerAheadInLane(){
		//Returning false if there isn't any attacker in lane.
		if (myLaneSpawner.transform.childCount <= 0) {
			return false;
		}
		//If attackers are ahead.
		foreach (Transform attacker in myLaneSpawner.transform) {
			if (attacker.transform.position.x > transform.position.x) {
				return true;
			}
		}
		// In every other case returning false, Including when attacker are @ back of defender.
		return false;
	}

	void setMyLaneSpawner(){
		Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();

		foreach (Spawner spawner in spawnerArray) {
			if (spawner.transform.position.y == transform.position.y) {
				myLaneSpawner = spawner;
				return;
			}
		}
		print (name + "can't find spawner in lane");
	}
	void fireGun(){
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gun.transform.position; 
	}
}
