using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class GameInstructionsImage : MonoBehaviour {

	public Renderer renderer;


	// Use this for initialization
	void Start () {
		print("Mouseover script has started.");
		renderer = GetComponent<Renderer>();
		Color c = renderer.material.color;
		c.a = (0.0f);
		renderer.material.color = c;
		StartCoroutine(Fade());
	}
    
	public void Update()
	{

	}
        
	IEnumerator Fade()
	{
		yield return new WaitForSeconds(2.0f);

		for (var g = -0.1f; g <= 1.1f; g += 0.03f)
		{
			Color c = renderer.material.color;
			c.a = g;
			renderer.material.color = c;
			yield return new WaitForSeconds(0.03f);
		}

	}
 
	//void OnMouseOver()
  //  {
		//renderer.material.color = Color.black;
  //  }

  //  void OnMouseExit()
  //  {
		//renderer.material.color = Color.white;
		////StartCoroutine(Fade());
    //}
 
}
