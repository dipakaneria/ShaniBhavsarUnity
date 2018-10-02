using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchVisibleTest : MonoBehaviour {

	public Renderer renderer;
	public int testScoreBranch;
	public GameObject branch;
	public int branches;


	// Use this for initialization
	void Start () {


		testScoreBranch = 225;
        

		branches = Resources.FindObjectsOfTypeAll(typeof(GameObject)).Length;
        
		for (int i = 0; i <= 30; i++)
		{
			print(branches);
		}
		//print("GameObject list = '" + branches + "'.");
//		branch = GameObject.FindWithTag("Branch10");
		//print("GameObject = '" + branch + "'.");
		//gameObject.SetActive = true;
            

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
