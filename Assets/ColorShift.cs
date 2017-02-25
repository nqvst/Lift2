using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShift : MonoBehaviour {

	SpriteRenderer ren;
	[SerializeField] Color color1;
	[SerializeField] Color color2;

	[SerializeField] float duration = 1;

	void Start () {
		ren = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		ren.color = Color.Lerp(color1, color2, lerp);
	}
}
