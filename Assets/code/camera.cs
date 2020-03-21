using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	// Use this for initialization
	GameObject player;
	Vector3 firstPos;
	emma em;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		em = player.GetComponent<emma>();
		firstPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (player.transform.position.x > firstPos.x)
		{
			var pos = transform.position;
			pos.x = player.transform.position.x;
			transform.position= pos;
		}
		else
		{
			transform.position = firstPos;
		}
	}
}
