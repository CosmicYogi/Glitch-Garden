using UnityEngine;
using System.Collections;
using UnityEngine.UI; // If want to do by using Image Component on the panel.

public class FadeIn : MonoBehaviour {

	CanvasRenderer can;
	private float colorKey = 1f;

	public float fadeInTime;
	private Image fadePanel;
	private Color currentColor = Color.black;

	// Use this for initialization
	void Start () {
		//My method from here
			//can = GetComponent<CanvasRenderer> ();
		//InvokeRepeating("FadingIn",1f,0.1f);
		//To here
		// UNCOMMENTING THE CODE ABOVE WILL ALSO RESULT IN FADEIN EFFECT.
		fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.timeSinceLevelLoad < fadeInTime) {
			//THIS IS LIKEAS THIS METHOD WOULD BE CALLED EVERY SECOND,
			//SO IT WOULD BE LIKE LOAD THIS BLOCK OF CODE TILL fadeInTime SECONDS.
			//THEN alphaChange IS HOW MUCH SHOULD ALPHA CHANGE.
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		} else {
			gameObject.SetActive (false);
		}
	}
		
	//My Method from here
	void FadingIn(){
		colorKey -= 0.07f;
		can.GetComponent<CanvasRenderer> ().SetAlpha (colorKey);
		if (colorKey <= 0) {
			Destroy (gameObject);
		}
	}
	//To here
}
