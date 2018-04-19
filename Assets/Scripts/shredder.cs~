using UnityEngine;
using System.Collections;

public class shredder : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag=="invader"){
			Main.enemyCount--;} //if a ship gets knocked in here -remove from shiplist 
		Destroy(col.gameObject);		
}
}