using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlePink : MonoBehaviour
{
    public float maxSpeed = 5;
    public float acceleration = 20;
    public float deacceleration = 4;
    float speed = 5f;
    
   

    Vector2 rawInput; //raw input values from the player
    Vector2 velocity; //Our current velocity
    Vector2 position; //our position
    Rigidbody2D rb20; //skapar låda

    // Start is called before the first frame update
    void Start()
    {
       
       

        rb20 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        //Get the raw input
        rawInput.x = Input.GetAxisRaw("Horizontal");
        rawInput.y = Input.GetAxisRaw("Vertical");

        //If we have a square magnitude over one, normalize the length of the vector to 1
        //if it's shorter then one we don't need this step.
        if (rawInput.sqrMagnitude > 1)
        {
            rawInput.Normalize();
        }

        //add our input to our velocity
        //This provides accelleration +10m/s/s
        velocity += rawInput * acceleration * Time.deltaTime;

        //Check our max speed, if our magnitude is faster them max speed
        if (velocity.sqrMagnitude > maxSpeed * maxSpeed)
        {
            //Normalize our velocity and change the magnitude to our max speed.
            velocity.Normalize();
            velocity *= maxSpeed;
        }

        //If we have zero input from the player
        if (rawInput.sqrMagnitude == 0)
        {
            //Reduce our speed based on how fast we are going
            //A value of 0.9 would remove 10% or our speed
            velocity *= 1 - deacceleration * Time.deltaTime;
        }

        //Update our position vector with our movement over time
        position += velocity * Time.deltaTime;

        //Gammal kod
        //position.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //fixar då om man har mindre fps
        //position.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //5 m per sekund

        //transform.position = position; //teleportation den struntar i om det är nåt ivägen
        rb20.velocity = velocity;
        
    }
}
