using UnityEngine;
using System.Collections;

public class CupAvatarMover : MonoBehaviour
{

	public Camera cam;
	public Rigidbody2D rb2D;

	private bool canControl;
	private float maxWidth;

	//Renderer stuff
	private Renderer rend;



	//Use this for initialization
	void Start ()
	{
		//print("CupAvatarMover.cs - Start() has been called.");
		if (cam == null) {
			cam = Camera.main;
		}
		rb2D = GetComponent<Rigidbody2D> ();
		//Renderer stuff
		rend = GetComponent<Renderer> ();

		canControl = false;
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		float cupWidth = rend.bounds.extents.x;
		maxWidth = targetWidth.x - cupWidth;


	}

	//Update is called once per physics timestep
	void FixedUpdate ()
	{
		

		if (canControl) {
			Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
			Vector3 targetPosition = new Vector3 (rawPosition.x, -2.91f, 0.0f);
			float targetWidth = Mathf.Clamp (targetPosition.x, -maxWidth, maxWidth);
			targetPosition = new Vector3 (targetWidth, targetPosition.y, targetPosition.z);
			rb2D.MovePosition (targetPosition);
		}
	}


	public void ToggleControl (bool toggle)
	{
		canControl = toggle;
	}
}
