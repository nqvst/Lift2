using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
	[SerializeField] Transform target;
	[SerializeField] Vector3 offset = new Vector3(0f, 0f, 0f);
	[SerializeField] float snoothing = 1;

	void Start() {
		transform.position = target.position + offset;
	}
		
	private void FixedUpdate()
	{
		transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.fixedDeltaTime * snoothing);
		transform.position = new Vector3 (transform.position.x, transform.position.y, -10);
	}
}