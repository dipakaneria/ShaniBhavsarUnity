using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaBreadPhysics: MonoBehaviour
{

	// Main script attached to each Prefab of falling items.
	// Controls forces affecting its movement from Instantiation
	// to end of gameObject life.



	private Rigidbody2D rb2d;
	private float randSpawnVector;
	private float randTorque;
	float speed;

	void Start ()
	{
//		print("BananaBreadPhysics.cs - Start() has been called.");
//		rb2d = GetComponent<Rigidbody2D>();
//		StartCoroutine(Power());
		speed = Random.Range (1f, 10f);
	}

	void Update ()
	{
	
		transform.Translate (Vector3.down * Time.deltaTime * speed);
		gameObject.transform.GetComponent<Rigidbody2D> ().AddForce (Vector2.down * speed * Time.deltaTime, ForceMode2D.Force); 
	}
	//	void FixedUpdate ()
	//	{
	//		gameObject.transform.GetComponent<Rigidbody2D> ().AddForce (Vector2.down * 30 * Time.deltaTime, ForceMode2D.Force);
	//
	//	}


	IEnumerator Power ()
	{

		//randSpawnVector = Random.Range(-10.0f, 10.0f);

		yield return new WaitForSeconds (0.0f);
		Vector2 item = new Vector2 (Random.Range (-1.5f, 1.5f), 0.0f);
		print ("Vector2 applied.");
		rb2d.AddForce (item, ForceMode2D.Impulse);
		yield return new WaitForSeconds (0.0f);
		randTorque = Random.Range (-10.0f, 10.0f);
		rb2d.AddTorque (randTorque, ForceMode2D.Force);
		// Fun path change during descent.
		yield return new WaitForSeconds (Random.Range (0.6f, 0.9f));
		float[] myVectorXArray = { -2.0f, 2.0f };
		Vector2 item2 = new Vector2 (myVectorXArray [Random.Range (0, myVectorXArray.Length)], 0.0f);
		rb2d.AddForce (item2, ForceMode2D.Impulse);
				
	}
}