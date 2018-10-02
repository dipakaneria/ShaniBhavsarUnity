using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomX : MonoBehaviour
{

    private int xRandom;
    public int xMin;
    public int xMax;



    // Use this for initialization
    void Start()
    {
        xRandom = Random.Range(xMin, xMax);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(xRandom, 0, 0);

    }
}
