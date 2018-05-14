using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroy : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "enemy") {
			//Destroy (arg.gameObject);
		}
	}
}
