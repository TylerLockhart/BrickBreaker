using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
         rb.velocity = new Vector3(0,0,10);       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        rb.velocity = new Vector3(0,0,-10);
    }
}
