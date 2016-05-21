using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print(PlayerPrefsManager.getMasterVolume ());
		PlayerPrefsManager.setMasterVolume (2.3f);
		print (PlayerPrefsManager.getMasterVolume ());
		PlayerPrefsManager.setMasterVolume (0.5f);
		print (PlayerPrefsManager.getMasterVolume());

		print (PlayerPrefsManager.isLevelUnlocked (1));
		print (PlayerPrefsManager.isLevelUnlocked (2));

		PlayerPrefsManager.unlockLevel (1);
		PlayerPrefsManager.unlockLevel (2);
		PlayerPrefsManager.unlockLevel (3);
		PlayerPrefsManager.unlockLevel (4);

		print (PlayerPrefsManager.isLevelUnlocked (1));
		print (PlayerPrefsManager.isLevelUnlocked (2));

		print (PlayerPrefsManager.isLevelUnlocked (122));

		print ("Difficulty is = " + (PlayerPrefsManager.getDifficulty()).ToString());
		PlayerPrefsManager.setDifficulty (0.44f);
		print ("Difficulty is = " + (PlayerPrefsManager.getDifficulty()).ToString());

	}

}
