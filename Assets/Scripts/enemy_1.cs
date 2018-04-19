using UnityEngine;
using System.Collections;



public class enemy_1 : MonoBehaviour {
	public int point_value =10;

	public bool alternate_sprite=false; 
	public float projectileSpeed=-3;
	public GameObject[] gosA;
	public GameObject projectile;
	

	// Use this for initialization
	void Start () {
		

	
	}
	void Fire(){ Vector3 newPosition = new Vector3(transform.position.x,transform.position.y ,transform.position.z);
		GameObject beam =Instantiate(projectile,(newPosition),Quaternion.identity) as GameObject;
		beam.GetComponent<Rigidbody2D>().velocity= new Vector3 (0,projectileSpeed,0);
		}
		
	
	// Update is called once per frame
	void Update () {
		
		gosA=GameObject.FindGameObjectsWithTag("enemy_fire");
		if (gosA.Length<2){
			int ran= Random.Range(1,500);
			if (ran==7){	
						Fire ();}
						}
						}
		
	


	
	}

