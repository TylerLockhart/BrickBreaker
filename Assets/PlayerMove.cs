﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerMove : MonoBehaviour
{
    public Rigidbody box; 
    // Start is called before the first frame update
    void Start(){

    }
        

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
             box.AddForce(500*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            box.AddForce(-500*Time.deltaTime, 0, 0);
        }
       
    
    }
}
