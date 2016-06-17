using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	const string MASK_FIRST_TIME = "Level_mask";

	public static void setMasterVolume (float volume){
		if (volume >= 0 && volume <= 1) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("volume not between 0 and 1");
		}
	}
	public static float getMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void unlockLevel(int level){
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1); // 1 for true
		} else {
			Debug.LogError ("Trying to unlock level that is not in build order");
		}
	}

	public static bool isLevelUnlocked(int level){
		if (PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ()) == 1) {
			return true;
		} else if (PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ()) == 0) {
			return false;
		} else {
			Debug.LogError ("Level you want to unlock isn't there");
			return false;
		}
	}

	public static void setDifficulty(float difficulty){
		if (difficulty >= 1 && difficulty <= 3) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError ("diffuculty not set in between 1 and 3");
		}
	}

	public static float getDifficulty(){
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}

	public static void setFirstTimeMaskIndicator(){
		// 1 for set and 0 for not.
		PlayerPrefs.SetInt(MASK_FIRST_TIME,1);
	}
	public static int getFirstTimeMaskIndicator(){
		return PlayerPrefs.GetInt (MASK_FIRST_TIME);
	}
}
