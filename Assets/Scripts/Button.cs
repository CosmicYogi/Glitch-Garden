using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	private Button[] buttonArray;
	private Text starCostText;
	public GameObject defenderPrefaf; //This is made so that an GameObjectPrefabs(OF DEFENDERS) corresponding to each individual button
	//can be dragged and dropped here for doing operations with GameObject corresponding to the respective Button.
	public static GameObject selectedDefender;
	// Use this for initialization
	void Start () {
		//this.GetComponent<SpriteRenderer> ().color = Color.black;
		buttonArray = GameObject.FindObjectsOfType<Button> ();
		starCostText = GetComponentInChildren<Text> ();
		starCostText.text = "" + defenderPrefaf.GetComponent<Defender> ().starCost;
	}

	void OnMouseDown(){
		print (name + "Tapped");
		this.GetComponent<SpriteRenderer> ().color = Color.white;
		foreach(Button button in buttonArray){
			button.GetComponent<SpriteRenderer> ().color = Color.black;
		}
		this.GetComponent<SpriteRenderer> ().color = Color.white;
		selectedDefender = defenderPrefaf;
		print (selectedDefender);
	}
}
