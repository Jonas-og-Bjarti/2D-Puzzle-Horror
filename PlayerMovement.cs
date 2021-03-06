using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        //input

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = new Vector2(movement.x, movement.y).normalized;
    }

    void FixedUpdate()
    {
        //movement

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        
    }
}
