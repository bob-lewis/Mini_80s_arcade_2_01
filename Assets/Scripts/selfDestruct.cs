using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {
	public float fuselength= 2f;

	// Use this for initialization
	void Start () {
		Object.Destroy(gameObject, fuselength);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
