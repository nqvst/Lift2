using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {


	ParticleSystem particles;
	ParticleSystem glow;

	float MAX_THRUST = 20;
	float thrust = 0;
	float currentThrust = 0;

	bool isThrusting = false;

	void Awake () {
		particles = GetComponent<ParticleSystem> ();
		glow =  transform.GetChild(0).GetComponent<ParticleSystem> ();
	}

	void Start() {
		applyThrust ();
	}

	void Update () {

		if (isThrusting) {
			this.thrust = MAX_THRUST;
		} else {
			this.thrust = 0;
		}

		if (currentThrust != thrust) {
			currentThrust = Mathf.Lerp (currentThrust, thrust, Time.deltaTime * 2);

		}
		applyThrust ();

		isThrusting = false;
	}

	public void doThrust() {
		isThrusting = true;
	}

	void applyThrust() {
		particles.startSpeed = currentThrust;
		glow.startSpeed = currentThrust;
	}

}
