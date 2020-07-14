using System.Collections;
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
             box.velocity = new Vector3(25,0,0);
        }
        else if (Input.GetKey("a"))
        {
            box.velocity = new Vector3(-25,0,0);
        }
        else{
            box.velocity = new Vector3(0,0,0);
        }
       
    
    }
}
