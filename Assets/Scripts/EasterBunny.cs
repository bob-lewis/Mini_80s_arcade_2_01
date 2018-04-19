using UnityEngine;
using System.Collections;

public class EasterBunny : MonoBehaviour {
	public GameObject egg1;//coin 1 
	public GameObject egg2;//coin 2
	public GameObject egg3;//coin 3

	private int hi ;
	public int pass1;
	public int pass2;
	public int pass3;
	public int pass4;
	public int pass5;
	public int pass6;







	// Use this for initialization
	void Start () {



	}
	void eggChecker(GameObject egg, int eggscore){
		hi = Main.hi_score;
	
		if (hi >= eggscore){
			egg.SetActive (true);
			print ("Mission accomplished") ;

		}
		

	}
		

	
	// Update is called once per frame
	void Update ()
	{///checks them in order (inelegant but works)
	if (hi<=pass1){
			eggChecker(egg1,pass1);}
		else if (hi<=pass2){
		eggChecker(egg2,pass2);}
		else if (hi<=pass3){
		eggChecker(egg3,pass3);}
	}
}
