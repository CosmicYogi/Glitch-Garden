using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	public GameObject[] attackerPrefabArray;
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisAttacker in attackerPrefabArray) {
			if (isTimeToSpawn (thisAttacker)) {
				spawn (thisAttacker);
			}
		}
	}

	void spawn(GameObject attacker){
		GameObject myAttacker = Instantiate(attacker) as GameObject;
		myAttacker.transform.parent = this.transform;
		myAttacker.transform.position = this.transform.position;
	}

	bool isTimeToSpawn(GameObject attackerGameObj){
		Attacker attacker = attackerGameObj.GetComponent<Attacker> ();
		float meanSpawnDealy = attacker.seenEverySeconds;
		float spawnsPerSecond = 1 / meanSpawnDealy;

		if (Time.deltaTime > spawnsPerSecond) {
			print ("Frame rate is acting as a CAP for Spawn Rate");
		}
		float threshold = spawnsPerSecond * Time.deltaTime / 4;

		if (Random.value < threshold) {
			return true;
		} else {
			return false;
		}

		//return true;
	}


}
