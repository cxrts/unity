using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyController : MonoBehaviour {
	NavMeshAgent nav;
	Animator zombie;
	Transform tr;
	public Transform target;

	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		zombie = GetComponent<Animator> ();
		tr = GetComponent<Transform> ();
	}
	
	void Update () {
		nav.SetDestination (target.position);
	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "player") {
			Destroy (arg.gameObject);
		}
		if (arg.gameObject.tag == "bullet") {
			zombie.SetFloat ("dead", 1.5f);
			nav.enabled = false;
		}
	}
}
