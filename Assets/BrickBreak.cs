using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreak : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnTriggerEnter(Collider collision){
        Destroy(gameObject);
    }*/
    
    void OnCollisionEnter(Collision collision){
        if (collision.collider.gameObject.name == "Ball")
        {
            Destroy(gameObject);
        }
    }
}
