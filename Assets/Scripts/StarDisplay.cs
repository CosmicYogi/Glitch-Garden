using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	private int numberOfStars = 100;
	private Text starText;
	public enum Status {SUCCESS,FAILURE}
		
	// Use this for initialization
	void Start () {
		starText = GetComponent<Text> ();
		updateDisplay ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addStars(int amount){
		numberOfStars += amount;
		updateDisplay ();
	}

	public Status useStars(int amount){
		if (numberOfStars >= amount) {
			numberOfStars -= amount;
			updateDisplay ();
			return Status.SUCCESS;
		}
		return Status.FAILURE;
	}

	private void updateDisplay(){
		starText.text = "" + numberOfStars;
	}
}
