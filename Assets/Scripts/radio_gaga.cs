using UnityEngine;
using System.Collections;

public class radio_gaga : MonoBehaviour {
	public bool powerOn=false;
	public AudioSource asour;

	// Use this for initialization
	void Start () {
	
	}
	
	public void flipswitch(){
	powerOn =! powerOn;
	
	}
	// Update is called once per frame
	void Update () {
	if (powerOn){
			asour.volume=0.8f;}
	else{
	asour.volume=0f;}
	
			
			
	
	}
}
