using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMask : MonoBehaviour {

	public Sprite mask2Image;
	enum State {
		Mask1, Mask2
	}
	State currentState = State.Mask1;
	void Start () {
		if (PlayerPrefsManager.getFirstTimeMaskIndicator () == 1) {
			Destroy (gameObject);
		} else {
			GetComponent<CircleCollider2D> ().enabled = false;
			Time.timeScale = 0;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (currentState == State.Mask1) {
			GetComponent<CircleCollider2D> ().enabled = true;
			GetComponent<PolygonCollider2D> ().enabled = false;
			this.GetComponent<Image> ().sprite = mask2Image;
			currentState = State.Mask2;
		} else if (currentState == State.Mask2) {
			PlayerPrefsManager.setFirstTimeMaskIndicator ();
			Time.timeScale = 1;
			Destroy (gameObject);
		}

	}
}
