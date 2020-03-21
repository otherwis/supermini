using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emma : MonoBehaviour {

	public float accForce = 5.0f;
	public float accJump = 10.0f;
	public float maxSpeed = 10.0f;
	Rigidbody2D rigb;

	public bool onSwing{get;set;}
	public bool dead{get;set;}

	public GameObject startPosObj;

	bool allowJump = false;
	//Collider2D collider;
	// Use this for initialization
	void Start () {
		rigb = this.GetComponent<Rigidbody2D>();
		//collider = this.GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -7.0f)
			dead = true;

		if (dead)
		{
			transform.position = startPosObj.transform.position;
			dead = false;
		}


		if (Input.GetKey(KeyCode.LeftArrow))
		{
			if (rigb.velocity.magnitude < maxSpeed && rigb.velocity.x <= 0)
				rigb.AddForce(Vector2.left * accForce);
		}
		if (Input.GetKey(KeyCode.RightArrow))
			if (rigb.velocity.magnitude < maxSpeed && rigb.velocity.x >= 0)
				rigb.AddForce(Vector2.right * accForce);

		if ((onSwing || allowJump) && Input.GetKey(KeyCode.UpArrow))
		{
			if (onSwing) 
			{
				transform.SetParent(null);
				enablePhisic(true);
				//set not on  swing
				onSwing = false;
				transform.localRotation = Quaternion.identity;
				rigb.velocity = Vector2.zero;
				rigb.AddForce(Vector2.up * accJump);

			}
			else if (allowJump)
			{
				if (rigb.velocity.y <= 0)
				{
					var t = rigb.velocity;
					t.y = 0;
					rigb.velocity = t;

					rigb.AddForce(Vector2.up * accJump);
					allowJump = false;
				}
			}
		}
	}


	void OnCollisionEnter2D(Collision2D col)
	{
		//Debug.Log("OnCollisionEnter2D");
		allowJump =true;
	}

	public void enablePhisic(bool isEnabled)
	{
		rigb.simulated = isEnabled;

	}
}
