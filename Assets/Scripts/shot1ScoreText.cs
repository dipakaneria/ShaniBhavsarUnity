using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shot1ScoreText : MonoBehaviour {

    public Text score1Text;



    // Use this for initialization
	void Start () {
        
        score1Text.gameObject.SetActive(true);
        score1Text.text = "Here's my score1Text.";

       


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
