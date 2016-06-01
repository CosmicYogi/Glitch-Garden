using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	private 
	AudioSource audioSource;
	public AudioClip[] levelMusicChangeArray;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake(){
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destry on load" + name); 
	}

	void OnLevelWasLoaded(int levelIndex){
		AudioClip thisLevelMusic = levelMusicChangeArray [levelIndex];
		Debug.Log ("Playing clip : " + thisLevelMusic);

		if (thisLevelMusic) { //If something is there in thisLevelMusic
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
			//audioSource.GetComponent<AudioSource> ().Play;
		}
	}

	public void SetVolume(float volume){
		audioSource.volume = volume;
	}
}
