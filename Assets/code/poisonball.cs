using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisonball : MonoBehaviour {

	public float die_time = 5.0f;
	float start_time;

	// Use this for initialization
	void Start () {
		start_time = Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - start_time>die_time)
		{
			GameObject.Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<emma>().dead = true;
		}
	}
}
