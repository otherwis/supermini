using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour {
	GameObject player;

	// Use this for initialization
	BoxCollider2D col;
	Rigidbody2D rig;
	bool fgo = false;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		rig = player.GetComponent<Rigidbody2D>();
		col = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//if (player.transform.position.y > transform.position.y && rig.velocity.y<0)
		if (rig.velocity.y<0)
		{
			col.enabled = true;
		}
		else
		{
			col.enabled = false;
		}
	}

}
