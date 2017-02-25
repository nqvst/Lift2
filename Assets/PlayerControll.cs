using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {

	[SerializeField] Transform leftEngine;
	[SerializeField] Transform rightEngine;

	[SerializeField] Engine leftThruster;
	[SerializeField] Engine rightThruster;

	Rigidbody2D body;

	[SerializeField] float force = 3;

	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.LeftShift)) {
			body.AddForceAtPosition (transform.up * force, leftEngine.position);
			leftThruster.doThrust ();
		}

		if (Input.GetKey (KeyCode.RightShift)) {
			body.AddForceAtPosition (transform.up * force, rightEngine.position);
			rightThruster.doThrust ();
		}
	}

}
