using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {
	public int scoreNeeded = 0;
	

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().enabled = false;}	
	// Update is called once per frame
	void Update () {
		if (Main.hi_score >scoreNeeded){	
			gameObject.GetComponent<Renderer>().enabled = true;
		}		
	
	}
}
