
using UnityEngine;
using System.Collections;

public class missile : MonoBehaviour {
	public GameObject explosion;


	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D col) {
	if (col.tag != "shredder"){
	
	Destroy(col.gameObject);

		if (Main.enemyCount >0) {Main.enemyCount --;
		Main.score++;
		}
		
		GameObject explode_enemy =Instantiate(explosion,transform.position,Quaternion.identity) as GameObject;

		
		}
		Object.Destroy(this.gameObject);}
	// Update is called once per frame
	void Update () {
	
	}
}/*


public class missile : MonoBehaviour {
	public GameObject explosion;
	
	
	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter2D(Collision2D col) {Destroy(col.gameObject);
		if (EnemySpawner.enemyCount >0) {EnemySpawner.enemyCount --;}
		GameObject explode_enemy =Instantiate(explosion,transform.position,Quaternion.identity) as GameObject;
		
		
		Object.Destroy(this.gameObject);}
	// Update is called once per frame
	void Update () {
	}}	*/