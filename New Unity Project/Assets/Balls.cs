﻿using UnityEngine;
using System.Collections;

public class Balls : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0f, 0f, Time.deltaTime * 1.0f);


        
	}
}
