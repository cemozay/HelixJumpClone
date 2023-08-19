using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool ignoreNextCollision;
    public Rigidbody rb;
    public float verticalForce;
    private void OnCollisionEnter(Collision other) {
        if (ignoreNextCollision){
            return;
        }

        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * verticalForce);
        
        ignoreNextCollision = true;
        Invoke("AllowCollision", .2f);

    }
    
    private void AllowCollision(){
        ignoreNextCollision = false;
    }

}
