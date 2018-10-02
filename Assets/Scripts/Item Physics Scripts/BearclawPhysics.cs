using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearclawPhysics : MonoBehaviour
{

	// Main script attached to each Prefab of falling items.
	// Controls forces affecting its movement from Instantiation
	// to end of gameObject life.
 
	private Rigidbody2D rb2d;
	float speed;

	void Start ()
	{
//        print("BearclawPhysics.cs - Start() has been called.");
//        rb2d = GetComponent<Rigidbody2D>();
//        StartCoroutine(Power());
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
		Vector2 item = new Vector2 (Random.Range (-1.0f, 1.0f), 0.0f);
		print ("Vector2 applied at Instantiation.");
		rb2d.AddForce (item, ForceMode2D.Impulse);
		yield return new WaitForSeconds (0.0f);
		// Random selection of torque values for the spin.
		float[] myTorqueArray = { -35.0f, 16.0f, -19.0f, 29.0f };
		rb2d.AddTorque (myTorqueArray [Random.Range (0, myTorqueArray.Length)]);

	}
}
