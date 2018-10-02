using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D trigger)
	{
		NextScene();
	}

	public void NextScene ()
	{
        Scene scene = SceneManager.GetActiveScene();
        print("Active scene is: '" + scene.name + "'.");
        print("Going to the next scene, which is: 'scene " + scene.buildIndex + 1 + "'.");

		if (scene.buildIndex <= SceneManager.sceneCountInBuildSettings)
		{
			SceneManager.LoadScene(scene.buildIndex + 1);
		}
		else
		{
			SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings);
			print("This is the last scene in the current Build, Folks.");
		}
	}


}
