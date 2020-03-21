using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squre : MonoBehaviour {

	// Use this for initialization
	float height;
	public float speed;
	public float maxHeight;
	void Start () {
		height = transform.position.y;
	}

	// Update is called once per frame
	void Update () {
		float h = height + maxHeight/2 + maxHeight/2 * Mathf.Sin(Time.time * speed);


		Vector2 pos = transform.position;
		pos.y = h;
		transform.position = pos;
	}
}
