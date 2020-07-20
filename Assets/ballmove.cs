using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    //rigidbody collider and directional component vectors
    public Rigidbody rb;
    public float verticalVector = 0f;
    public float horizontalVector = 0f;
    
    //handle collisions with bricks; compatible with OnTriggerEnter
    /*void brickBounce (Collider other){
        GameObject brick = other.gameObject;
        Transform bTrans = brick.transform;
        //Debug.Log(bTrans.position.x); //checking structure of Transform objects
        Vector3 brickLocation = new Vector3(bTrans.position.x, bTrans.position.x, bTrans.position.z); // this line is the one that breaks
        //Debug.Log(brickLocation.z - rb.gameObject.transform.position.z); //check distance between z coordinates at collision
        //Debug.Log(rb.gameObject.transform.position.z); Left in for reference purposes
        float differenceZ = brickLocation.z - rb.gameObject.transform.position.z;
        Debug.Log(differenceZ);
        if(differenceZ < 0){
            differenceZ *= -1;
        }
        if(differenceZ  > 1){
            verticalVector *= -1;
            rb.velocity = new Vector3(horizontalVector, 0, verticalVector);
        }
        else{
            horizontalVector *= -1;
            rb.velocity = new Vector3(horizontalVector, 0, verticalVector);
        }
    }*/
    void brickBounce(Collision col){
        
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

    /*void OnTriggerEnter(Collider other){
        //handle brick collisions
        if (other.tag == "Brick")
        {
            //verticalVector *= -1;
            //rb.velocity = new Vector3(horizontalVector, 0 , verticalVector);
            brickBounce(other);
        }
        //handle paddle collisions
        if(other.tag == "Paddle"){
            verticalVector *= -1;
            rb.velocity = new Vector3(horizontalVector, 0 , verticalVector);
        }
    }*/
    void OnCollisionEnter(Collision col){
        Debug.Log("On Collision Enter");
        Debug.Log(col.gameObject.name);
        //Debug.Log(col.GetContact[0]);
        verticalVector *= -1;
        rb.velocity = new Vector3(horizontalVector, 0, verticalVector);
    }
}
