using UnityEngine;
using System.Collections;

public class Button_press_left : MonoBehaviour {
	public bool checker;
	public float buttonUp;
	public float buttonDown;

	
	// Use this for initialization
	void Start () {
		checker=false;
		buttonUp=this.transform.position.y;
		buttonDown=buttonUp - 0.09f;
		
		//Vector3 buttonUp= new Vector3( this.transform.position.x, (this.transform.position.y), this.transform.position.z);
		//Vector3 buttonDown =  new Vector3( this.transform.position.x, (this.transform.position.y - 0.03f), this.transform.position.z);
		
		
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		float move;
		
		if (checker==true){
			move=buttonDown;}
		else { move =buttonUp;}
		
		Vector3 buttonPos = new Vector3 ( this.transform.position.x,move, this.transform.position.z);
		
		this.transform.position=buttonPos;
		
		
		
	}
}
