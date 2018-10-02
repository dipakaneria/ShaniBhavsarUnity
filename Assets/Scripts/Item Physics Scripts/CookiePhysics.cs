﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookiePhysics : MonoBehaviour
{

	// Main script attached to each Prefab of falling items.
	// Controls forces affecting its movement from Instantiation
	// to end of gameObject life.



	private Rigidbody2D rb2d;
	private float randSpawnVectorX;
	private float randTorque;
	float speed;

	void Start ()
	{
//		print ("CookiePhysics.cs - Start() has been called.");
//		rb2d = GetComponent<Rigidbody2D> ();
//		StartCoroutine (Power ());
		speed = Random.Range (1f, 10f);
	}

	void Update ()
	{
	
//		transform.Translate (Vector3.down * Time.deltaTime * speed);
		gameObject.transform.GetComponent<Rigidbody2D> ().AddForce (Vector2.down * speed * Time.deltaTime, ForceMode2D.Force); 
	}
	//	void FixedUpdate ()
	//	{
	//		gameObject.transform.GetComponent<Rigidbody2D> ().AddForce (Vector2.down * 30 * Time.deltaTime, ForceMode2D.Force);
	//
	//	}


	IEnumerator Power ()
	{
        
		yield return new WaitForSeconds (0.0f);
		// Specify the x-axis ForceMode2D values to be used.
		//int[] randomXArray = { -2, 2};
		// Randomize the selection of the values.
		//randSpawnVectorX = randomXArray[Random.Range(0, randomXArray.Length)];
		Vector2 item = new Vector2 (1.0f, 0.0f);
		rb2d.AddForce (item, ForceMode2D.Impulse);
		yield return new WaitForSeconds (0.0f);
		randTorque = Random.Range (-20.0f, 20.0f);
		rb2d.AddTorque (randTorque, ForceMode2D.Force);

	}

}