using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 10f;
    float maxSpeed = 10f;
  float  jumpImpulse = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
//  void FixedUpdate(){
    
//  }
    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        Debug.Log(horizontalMovement);
        Rigidbody rbody = GetComponent<Rigidbody>();
        rbody.velocity += Vector3.right*horizontalMovement * Time.deltaTime;
        Debug.Log(rbody.velocity);

        Collider col = GetComponent<Collider>();
        float halfHeight = col.bounds.extents.y +0.03f;

        Vector3 startPoint = transform.position;
        Vector3 endPoint = startPoint + Vector3.down * halfHeight;


        // isGrounded = Physics.Raycast(origin: startPoint, direction: Vector3.down, halfHeight);
        // Color lineColor = (isGrounded)

        if (Input.GetKeyDown(KeyCode.Space)){
            rbody.AddForce(Vector3.up * jumpImpulse,ForceMode.Impulse);
        }
        
        if(Math.Abs(rbody.velocity.x) > maxSpeed)
        {
            Vector3 newVel = rbody.velocity;
            // newVel.x maxSpeed;
            rbody.velocity = newVel;
        rbody.velocity = rbody.velocity.normalized* maxSpeed;
        }
        // Vector3 startPoint = transform.position;
        // Vector3 endPoint = startPoint + Vector3.down *2f;
        Debug.DrawLine(startPoint,endPoint,Color.blue, duration: 0f, depthTest: true);
    }
}
