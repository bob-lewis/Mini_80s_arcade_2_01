using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {
void OnDrawGizmos(){
		if (this.tag=="enemy1"){
			Gizmos.color = Color.yellow;}
		else if (this.tag=="enemy2"){
			Gizmos.color = Color.green;}
		else{
			Gizmos.color = Color.red;}
		Gizmos.DrawWireSphere(transform.position, 0.1f);
	}
}
