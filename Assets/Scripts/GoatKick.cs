using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class GoatKick : MonoBehaviour
{
    
	public Animator anim;



	IEnumerator stopAnim ()
	{
		yield return new WaitForSeconds (1);
//		anim.gameObject.SetActive (false);
	}

	void OnTriggerEnter2D (Collider2D trigger)
	{
		if (trigger.gameObject.tag == "CatchLevel1" ||
		    trigger.gameObject.tag == "CatchLevel2" ||
		    trigger.gameObject.tag == "CatchLevel3" ||
		    trigger.gameObject.tag == "CatchLevel4") {
			print ("GoatKick.cs - Triggered.");
//			anim.gameObject.SetActive (true);
			anim = GetComponentInChildren<Animator> ();
			anim.Play ("goat_kick");
			StartCoroutine (stopAnim ());
		}
	}
}
