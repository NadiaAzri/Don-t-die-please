using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour {

	[HideInInspector]
	public float speed;

	private Rigidbody2D myBody;

	// Use this for initialization
	void Awake () {

		myBody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		myBody.velocity = new Vector2(speed, myBody.velocity.y);
		
	}
}
