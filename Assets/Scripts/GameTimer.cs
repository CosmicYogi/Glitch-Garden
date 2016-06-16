using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

	private Slider slider;
	private LevelManager lm;
	private GameObject winLabel;
	private bool isEndOfLevel = false;

	public float levelSeconds = 100;
	// Use this for initialization
	void Start () {
		lm = GameObject.FindObjectOfType<LevelManager> ();
		slider = GetComponent<Slider> ();
		winLabel = GameObject.Find ("You Won");
		if (!winLabel) {
			print ("Plz, Create a UIText with name 'You Won'");
		}
		winLabel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);

		if (timeIsUp && !isEndOfLevel) {
			handleWinCondition ();
		}
	}
	void handleWinCondition(){
		destroyAllTargetObjects ();
		winLabel.SetActive (true);
		Invoke ("loadNextLevel", 3);
		isEndOfLevel = true;
	}
	//Destroys all objects with destroyOnWin tag.
	void destroyAllTargetObjects(){
		GameObject[] deletingObjects = GameObject.FindGameObjectsWithTag ("destroyOnWin");
		foreach(GameObject deletingObject in deletingObjects) {
			Destroy(deletingObject);
		}
	}
	void loadNextLevel(){
		lm.LoadNextLevel ();
	}

}
