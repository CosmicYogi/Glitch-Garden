using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public Sprite pause;
	public Sprite play;
	private SpriteRenderer spriteRenderer;
	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	void OnMouseDown(){
		if (Time.timeScale != 0) {
			spriteRenderer.sprite = play;
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) {
			spriteRenderer.sprite = pause;
			Time.timeScale = 1;
		}
	}
}
