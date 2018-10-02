using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostGameScript : MonoBehaviour {


	public Text mt;


	// Use this for initialization
	void Start () {
		print("Here's mazelTov: " + GameController.mazelTov);
	}
	
	// Update is called once per frame
	void Update () {
		if(GameController.mazelTov == 1)
		{
			mt.text = "First Mazel Tov count is:\n" + GameController.mazelTov; 
		}
		else if (GameController.mazelTov == 2)
		{
			mt.text = "Second Mazel Tov count is:\n" + GameController.mazelTov;
		}
	}
}
