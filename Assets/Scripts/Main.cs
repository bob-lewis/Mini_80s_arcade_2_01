﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Main : MonoBehaviour {
	public GameObject enemyPrefab1;
	public GameObject enemyPrefab2;
	public GameObject enemyPrefab3;
	public GameObject ufoPrefab;
	static public int score = 0;
	static public int lives = 3;
	static public int savedHiScore=0;
	static public int hi_score = 36;
	public float width = 10f;
	public float height = 3f;
	public bool movingRight = true;
	static public float enemyCount;
	public float speed = 30f;
	public GameObject CRT ;
	public float x_min;
	public float x_max ;
	public float y_max;
	public float buffer=1;
	public float half_screen;
	public float adaptingSpeed;
	public Vector3 start_point ;
	public Text text_score;
	public Text text_hi;
	static public bool reset=false;
	static public bool coin_inserted=true;
	public bool end_game=true;
	public int counter;
	public int note;
	private  moveSound bumpNoise;
	public GameObject tank;
	private Vector3 startpos;
	static public bool lookleft=false;
	static public bool lookright=false;



	// Use this for initialization
	void Start () {
		Vector3 startpos = new Vector3(0,-1,0);
		counter = 0;
		note = 0;
		savedHiScore = PlayerPrefs.GetInt ("HighScore");
			if (savedHiScore>=hi_score){
				hi_score=savedHiScore;
			}
		//half_screen =CRT.GetComponent<BoxCollider2D>().size.x  /2;
		bumpNoise = GameObject.FindObjectOfType<moveSound> ();
		half_screen =6.485f;
		x_max=CRT.transform.position.x + half_screen;
		x_min=CRT.transform.position.x - half_screen;
		Invasion();
			
		GameObject player = Instantiate(tank,startpos,Quaternion.identity)  as GameObject;
		

		}


	void InvadersMustDie(){

		 GameObject[] invaders;
		//player dies? this deletes remaining enemies and resets, cant addmultiple tags at once so runs 3 times:(
		invaders= GameObject.FindGameObjectsWithTag("invader");
		foreach(GameObject invader in invaders){
		Destroy (invader);
		}
		
		}
	
	
	
	
	void Invasion(){
		
		GameObject enemyPrefab;
		this.transform.position= start_point;
		
	
	foreach( Transform child in transform){//for every transform in the Enemyformation
		//print (child.tag);
		if (child.tag =="enemy2"){ enemyPrefab=enemyPrefab2;}
		else if (child.tag =="enemy3"){ enemyPrefab=enemyPrefab3;}
		else{enemyPrefab=enemyPrefab1;}
		GameObject enemy = Instantiate(enemyPrefab, child.transform.position,Quaternion.identity) as GameObject;
		enemy.transform.parent = child;
		enemyCount ++;}
		}
	public void OnDrawGizmos(){ 
		float y_moved = this.transform.position.y-.2f;
		float x_moved = this.transform.position.x;
		Vector2 temp= new Vector2  (x_moved,y_moved);
		Gizmos.DrawWireCube(temp,new Vector3(width,height));
	}
	public  void gaze_on_left_button(){
		lookright=false;
		lookleft=true;}
		
	public void gaze_on_right_button(){
		lookleft=false;
		lookright=true;}
		
	public void avert_gaze(){
		lookright=false;
		lookleft=false;}
		
	void bump(){
	
		if (counter >= enemyCount+5) {//STARTS AT 50 , ENDS AT 5
			counter = 0;
			//print (counter+" "+ note); 
			bumpNoise.makeSound (note);
			note++;
			if (note>=4){
				note = 0;}
			
			}
		else counter++;
	}
	// Update is called once per frame
	void Update () {
	bump ();
		
		if (reset==true){
			InvadersMustDie();
			Vector3 startpos = new Vector3(0,-1,0);
			if (GameObject.FindWithTag("Tank")==false){
			
				GameObject player = Instantiate(tank,startpos,Quaternion.identity)  as GameObject;}
			print ("deleted all");
			enemyCount=0;
		                         
		
				reset=false;	
			
				
		}
	
		if (score>hi_score){
			hi_score=score;}
		if (enemyCount <= 0){
		Invasion();}
		text_score.text = score.ToString();
		text_hi.text = hi_score.ToString();

			

		float rightEdgeofFormation=transform.position.x+(width/2);
		float leftEdgeofFormation=transform.position.x-(width/2);

		if (leftEdgeofFormation<= x_min ){
				
			transform.position +=  Vector3.down * 1f * Time.deltaTime;
				movingRight =true;
			}
		else if(rightEdgeofFormation >= x_max){
			transform.position +=  Vector3.down * 1f * Time.deltaTime;
			movingRight=false;}


		 adaptingSpeed = speed/enemyCount;
		if (movingRight && reset==false){
				transform.position +=  Vector3.right* adaptingSpeed*Time.deltaTime;}
		else{if  (reset==false){
			transform.position +=  Vector3.left* adaptingSpeed*Time.deltaTime;}

	
	}
}
}


