using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;
	private GameObject defenderParent;
	// Use this for initialization
	void Start () {
		defenderParent = GameObject.Find ("defenderParent");
		if (!defenderParent) {
			defenderParent = new GameObject ("defenderParent");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Vector2 position = snapToGrid (calculateWorldPointOfMouseClick ());
		Vector3 positionToInstantiate = new Vector3 (position.x,position.y,-1);
		// positionToInstantiate is made with X & Y coordinates with -1 z coordinates so that only 1 Defender instantiate on on position.
		// Because if we make Z-coordinate -1 then it comes in front and because there is collider on every Defender so that collider - 
		// - don't allows the instantiation of new Defender.
		GameObject defender = Instantiate (Button.selectedDefender, positionToInstantiate, Quaternion.identity) as GameObject;
		defender.transform.parent = defenderParent.transform;


	}

	Vector2 calculateWorldPointOfMouseClick(){
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float distanceFromCamera = 10f;
		Vector3 triplet = new Vector3(mouseX,mouseY,distanceFromCamera);
		Vector2 worldPosition = myCamera.ScreenToWorldPoint(triplet);
		return worldPosition;
	}

	Vector2 snapToGrid(Vector2 coordinate){
		coordinate.x = Mathf.Round (coordinate.x);
		coordinate.y = Mathf.Round (coordinate.y);
		Vector2 coordinates = new Vector2 (coordinate.x, coordinate.y);
		return(coordinates);
	}
}
