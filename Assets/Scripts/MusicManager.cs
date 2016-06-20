using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	private 
	AudioSource audioSource;
	public AudioClip[] levelMusicChangeArray;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.volume = PlayerPrefsManager.getMasterVolume (); //FOR SETTING UP THE DEFAULT VOLUME WHEN GAME LOADS.
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake(){
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destry on load" + name); 
	}

//	void OnLevelWasLoaded(int levelIndex){
//		AudioClip thisLevelMusic = levelMusicChangeArray [levelIndex];
//		Debug.Log ("Playing clip : " + thisLevelMusic);
//
//		if (thisLevelMusic) { //If something is there in thisLevelMusic
//			audioSource.clip = thisLevelMusic;
//			audioSource.loop = true;
//			audioSource.Play ();
//		} else {
//			Debug.Log ("Nothing in this level music" + thisLevelMusic);
//		}
//	}

	public void SetVolume(float volume){
		audioSource.volume = volume;
	}
}
