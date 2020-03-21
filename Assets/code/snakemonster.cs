using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakemonster : MonoBehaviour {

	public GameObject[] balls;
	public float fire_interval = 1.0f;
	// Use this for initialization
	float time=0;
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - time > fire_interval)
		{
			Fire();
			time = Time.time;
		}
	}

	void Fire()
	{
		Random.InitState((int)Time.time);
		int idx = Random.Range(0,3);
		var ball = GameObject.Instantiate(balls[idx]);
		if (ball)
		{
			ball.transform.position = transform.position;
			
			ball.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 1000f);
		}
	}
}
