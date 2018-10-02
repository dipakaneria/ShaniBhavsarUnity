using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupInnerScript : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag.Equals ("CatchLevel1") || other.tag.Equals ("CatchLevel2") || other.tag.Equals ("K_coin")) {
			other.GetComponent<CircleCollider2D> ().isTrigger = false;
		} else if (other.tag.Equals ("AvoidLevel4")) {
			other.GetComponent<CapsuleCollider2D> ().isTrigger = false;
		} else {
			other.GetComponent<PolygonCollider2D> ().isTrigger = false;
		}
			
	}

}
