using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAtSpawnPosX : MonoBehaviour {

	public Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 item = new Vector2(2.0f, 0.0f);
        rb2d.AddForce(item);
    }
}


//Random.Range(-3.0f, 3.0f)