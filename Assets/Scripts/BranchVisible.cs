﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;

//import UnityEngine.UI;
using UnityEngine.UI;
using System.Text;
using System.Security.Principal;





public class BranchVisible : MonoBehaviour
{

	public GameObject Level01;
	public GameObject Level02;
	public GameObject Level03;
	public GameObject Level04;
	public GameObject Level05;
	public GameObject Level06;
	public GameObject Level07;
	public GameObject Level08;
	public GameObject Level09;
	public GameObject Level10;

	public Text shot1ScoreText;
	public Text shot1BranchText;
	public Text shot2ScoreText;
	public Text shot2BranchText;



	public GameObject BranchBlocker;


	private static Score data;
	public int gameScore;
	public Text scoreText;
 
	// Use this for initialization
	void Start ()
	{
        


		//data = this;
		if (File.Exists (Application.persistentDataPath + "/save.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/save.dat", FileMode.Open);
			ScoreData scoredata = (ScoreData)bf.Deserialize (file);
			gameScore = scoredata.gameScore;
			file.Close ();
		} else {
			gameScore = 0;
		}

		scoreText.gameObject.SetActive (true);
		scoreText.text = gameScore.ToString ();

		if (gameScore < 125) {
			Level01.SetActive (true);
		} else if (gameScore >= 125 && gameScore < 250) {
			Level02.SetActive (true);
		} else if (gameScore >= 250 && gameScore < 375) {
			Level03.SetActive (true);
		} else if (gameScore >= 375 && gameScore < 500) {
			Level04.SetActive (true);
		} else if (gameScore >= 500 && gameScore < 625) {
			Level05.SetActive (true);
		} else if (gameScore >= 625 && gameScore < 750) {
			Level06.SetActive (true);
		} else if (gameScore >= 750 && gameScore < 825) {
			Level07.SetActive (true);
		} else if (gameScore >= 825 && gameScore < 950) {
			Level08.SetActive (true);
		} else if (gameScore >= 950 && gameScore < 1075) {
			Level09.SetActive (true);
		} else if (gameScore >= 1075) {
			Level10.SetActive (true);
		}
		#region
		if (GameController.mazelTov == 1) {
			print ("mazelTov_One!");
		}

		if (GameController.mazelTov == 2) {
			print ("mazelTov_Two!");
		}
		#endregion

		if (GameController.mazelTov == 1) {
			shot1ScoreText.gameObject.SetActive (true);
			shot1BranchText.gameObject.SetActive (true);
			shot1ScoreText.text = "Congrats! Your scored\n" + gameScore +
			"\n with your first shot.";
			shot1BranchText.text = "To grow your coffee bean branch,\n" +
			" tap the button below\nand drink\nyour second shot!";

		} else if (GameController.mazelTov == 2) {
			shot2ScoreText.gameObject.SetActive (true);
			shot2BranchText.gameObject.SetActive (true);
			shot2ScoreText.text = "Good job! Your score is now\n" + gameScore +
			"\nafter your second shot.";
			shot2BranchText.text = "You have one more chance -\n" +
			"drink your third shot and go!";

		}

       
  
	}
	
	// Update is called once per frame
	void Update ()
	{
        
	}

	public void ScoreGame ()
	{

	}
}
