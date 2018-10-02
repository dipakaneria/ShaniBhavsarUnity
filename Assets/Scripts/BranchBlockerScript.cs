using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using sys = System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;
using System.Text;



public class BranchBlockerScript : MonoBehaviour {

    public GameObject branchBlocker;

    //private void Awake()
    //{
    //    branchBlocker.transform.position = new Vector3(-0.1f, 0.03f, 0.0f);
    //}

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(BranchBlockMover());
        print("BranchBlocker coroutine called.");
	}
	
	// Update is called once per frame
	void Update () {
        //branchBlocker.transform.position += new Vector3(2.0f * Time.deltaTime, 0.0f, 0.0f);
	}

    IEnumerator BranchBlockMover()
    {
        yield return new WaitForSeconds(1.0f);
        while(branchBlocker.transform.position.x < 6.0f)
        {
            branchBlocker.transform.position += new Vector3(4.0f * Time.deltaTime, 0.0f, 0.0f);
            yield return new WaitForSeconds(Time.deltaTime);
        }
        print("Time.deltaTime = " + Time.deltaTime);
    }



}
