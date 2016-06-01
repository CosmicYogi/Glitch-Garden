using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider,difficultySlider; 
	public LevelManager levelManager;

	private float difficulty;
	private MusicManager musicManager;
	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> (); 
		volumeSlider.value = PlayerPrefsManager.getMasterVolume();
		difficultySlider.value = PlayerPrefsManager.getDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume (volumeSlider.value);
		//print (volumeSlider.value);
	}
	public void SaveAndExit(){
		PlayerPrefsManager.setMasterVolume (volumeSlider.value);
		PlayerPrefsManager.setDifficulty (difficultySlider.value);
		levelManager.LoadLevel ("01a Start");
	}
	public void SetDefaults(){
		volumeSlider.value = 0.6f;
		difficultySlider.value = 2;
		Debug.Log ("Volume set to : " + volumeSlider.value + ",Difficulty set to : " + difficultySlider.value);
	}
}
