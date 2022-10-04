using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody rb;

    Vector3 movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Simple x and y 2d movement of the player
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
           // Debug.Log("Pressed primary button.");
        }
            

        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("Pressed secondary button.");
        }
          
    }

    private void FixedUpdate()
    {
        //Method used to implament movement and speed
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
