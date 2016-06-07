using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (-1.5f,2f)] //Add this block above declaration to range it's value.
	public float walkSPeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector2.left * walkSPeed * Time.deltaTime);
	}
}
