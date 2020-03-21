using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("trigger");
		if (col.gameObject.tag == "Player")
		{
			if (col.gameObject.GetComponent<Rigidbody2D>().velocity.y<0)
			{

			col.gameObject.GetComponent<emma>().enablePhisic(false);
			col.gameObject.GetComponent<emma>().onSwing = true;

			col.gameObject.transform.SetParent(transform);
			col.gameObject.transform.localPosition = new Vector3(0,-0.3f,0);
			col.gameObject.transform.localRotation = Quaternion.identity;

			}
		}
	}
}
