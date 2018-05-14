using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

	Rigidbody rb;
	Transform tr;
	float v;
	float h;
	float f;
	float m;
	public Rigidbody mainObject;
	public Transform dulo;
	Rigidbody clone;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
	}

	void Update () {
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
		m = Input.GetAxis ("Mouse X");
		f = Input.GetAxis ("Fire1");
		rb.AddForce (tr.forward * v * 100f);
		Vector3 rotation = new Vector3 (0, m, 0);
		tr.Rotate (rotation * 4.5f);
		if (f > 0) {
			clone = Instantiate (mainObject, dulo.position, dulo.rotation);
			clone.AddForce (tr.forward * 3000f);

		}
	}
}
