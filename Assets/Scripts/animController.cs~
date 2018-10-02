using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1"))
		//if (gameObject.tag == "CatchLevel1")
		{
			anim.Play("goat_kick");
			print("First kick.");
			//anim.Play("goat_kick", 0, .5f);
			//print("Second kick.");
		}
		else if(Input.GetKeyDown("2"))
		{
			anim.Play("stop");
		}
	}
}
