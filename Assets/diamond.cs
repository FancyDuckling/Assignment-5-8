using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    float speed = 5f;
    Vector2 position;
    Vector2 velocity; // we start without velocity
    Vector2 acceleration = new Vector2(0, 0); 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //fixar då om man har mindre fps
        velocity.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //5 m per sekund

        velocity += acceleration * Time.deltaTime;

        //We move our position based on our velocity
        position += velocity * Time.deltaTime;

        //we move our gameObject based on our position
        transform.position = position;


    }
}
