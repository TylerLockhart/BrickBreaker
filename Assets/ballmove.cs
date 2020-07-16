using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    //rigidbody collider and directional component vectors
    public Rigidbody rb;
    public float verticalVector = 0f;
    public float horizontalVector = 0f;
    
    //handle collisions with bricks
    void brickBounce (Collider other){
        GameObject brick = other.gameObject;
        Transform bTrans = brick.transform;
        Vector3 brickLocation = new Vector3(bTrans.position);
        //if()
    }    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        verticalVector = 10;
        horizontalVector = 0;
        rb.velocity = new Vector3(horizontalVector,0,verticalVector);       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        //handle brick collisions
        if (other.tag == "Brick")
        {
            verticalVector *= -1;
            rb.velocity = new Vector3(horizontalVector, 0 , verticalVector);
        }
        //handle paddle collisions
        if(other.tag == "Paddle"){
            verticalVector *= -1;
            rb.velocity = new Vector3(horizontalVector, 0 , verticalVector);
        }
    }
}
