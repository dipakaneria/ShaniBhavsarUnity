using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PregameImageMover : MonoBehaviour {

    public Camera cam;
	public Rigidbody2D rb2D;

	private bool canControl;
	private float maxWidth;

	//Renderer stuff
	private Renderer rend;


	//Use this for initialization
	void Start ()
	{
		print("PregameImageMover.cs - Start() has been called.");
        if (cam == null){
            cam = Camera.main;
        }
		rb2D = GetComponent<Rigidbody2D> ();
		//Renderer stuff
		rend = GetComponent<Renderer> ();

		canControl = true; // Set to false in CupAvatarMover.
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		float imageWidth = rend.bounds.extents.x;
		maxWidth = targetWidth.x - imageWidth;

	}

	//Update is called once per physics timestep
	void FixedUpdate () {
		if (canControl) {
			Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
			Vector3 targetPosition = new Vector3 (rawPosition.x, 2.0f, 0.0f);
			float targetWidth = Mathf.Clamp (targetPosition.x, -maxWidth, maxWidth);
			targetPosition = new Vector3 (targetWidth, targetPosition.y, targetPosition.z);
			rb2D.MovePosition (targetPosition);
		}
	}
	public void ToggleControl (bool toggle) {
		canControl = toggle;
	}
}
