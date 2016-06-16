using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Pause : MonoBehaviour {

	private GameObject coreGame;
	public Sprite pause;
	public Sprite play;
	private SpriteRenderer spriteRenderer;

	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer> ();
		coreGame = GameObject.Find("core game");
	}

	void OnMouseDown(){
		if (Time.timeScale != 0) {
			spriteRenderer.sprite = play;
			coreGame.GetComponent<BoxCollider2D> ().enabled = false;
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) {
			spriteRenderer.sprite = pause;
			coreGame.GetComponent<BoxCollider2D> ().enabled = true;
			Time.timeScale = 1;
		}
	}
}
