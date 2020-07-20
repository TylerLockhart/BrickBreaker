using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    //rigidbody collider and directional component vectors
    public Rigidbody rb;
    public float verticalVector = 0f;
    public float horizontalVector = 0f;
    
    //handles collisions with bricks and walls; compatible with on collision enter
    void brickBounce(Collision col){
        float verticalDiff = col.GetContact(0).point.z - col.collider.gameObject.transform.position.z;
        float horizontalDiff = col.GetContact(0).point.x - col.collider.gameObject.transform.position.x;
        Debug.Log(verticalDiff);
        Debug.Log(horizontalDiff);
        //vertical collisions
        if (verticalDiff == 0.5){
            if (verticalVector < 0){
                verticalVector *= -1;
                rb.velocity = new Vector3(horizontalVector, 0, verticalVector);
            }
        }
        if (verticalDiff == -0.5){
            if (verticalVector > 0){
                verticalVector *= -1;
                rb.velocity = new Vector3(horizontalVector, 0, verticalVector);
            }
        }
        
        //side collisions
        if (horizontalDiff == 1.5){
            if (horizontalVector < 0){
                horizontalVector *= -1;
                rb.velocity = new Vector3(horizontalVector, 0, verticalVector);
            }
            
        }
        if (horizontalDiff == -1.5){
            if (horizontalVector > 0){
                horizontalVector *= -1;
                rb.velocity = new Vector3(horizontalVector, 0, verticalVector);
            }
        }
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        verticalVector = 3;
        horizontalVector = -3;
        rb.velocity = new Vector3(horizontalVector,0,verticalVector);       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col){
        if (col.collider.gameObject.tag == "Brick")
        {
            brickBounce(col);
        }
        
    }
}
