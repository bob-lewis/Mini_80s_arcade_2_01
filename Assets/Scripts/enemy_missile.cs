using UnityEngine;
using System.Collections;

public class enemy_missile : MonoBehaviour {

			public GameObject explosion;
			
			
			// Use this for initialization
			void Start () {
				
			}
			void OnTriggerEnter2D(Collider2D col) {
				if (col.tag != "shredder"){
					Destroy(col.gameObject);			
					
					
					if (Main.lives >0) {Main.lives --;
						Main.reset=true;
					}
					else{Main.score=0;
					Main.coin_inserted=false;
					Main.lives=3;
					Main.reset=true;} 															
					GameObject explode_enemy =Instantiate(explosion,transform.position,Quaternion.identity) as GameObject;
					
					
				}
				Object.Destroy(this.gameObject);}
			// Update is called once per frame
			void Update () {
				
			}
		}
