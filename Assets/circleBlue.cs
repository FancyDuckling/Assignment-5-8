using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleBlue : MonoBehaviour
{
    float speed = 5f;
        
   //0.05f; //detta blir en dålig hastighet om man har färre frames men man kan lösa med deltatime
    
    Vector2 position; //fixa en position

    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //från lärare circle 
        if (Input.GetKeyDown(KeyCode.R)) //om man tar bort Down gör den detta en gång per frame
        {
            Debug.Log("Player is realoading");
        }

        if (Input.GetButton("Jump"))//denna finns i inputmanager i unity så den vet att den kllar på space
        {
            Debug.Log("player is jumping");
        }

        //Joystick kan man inte ha true eller false för den kan luta lite grann
        //getaxis ger en mjuk övergång, skarpare använd axisraw
        position.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //fixar då om man har mindre fps
        position.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //5 m per sekund

        transform.position = position;


        //velocity konstant movement åt ett håll 
        position.x += speed * Time.deltaTime;
        //acceleration 
        speed *= 1.1f;
        speed += speed * 1.1f * Time.deltaTime; //acceleration över tid


        //tar position och ökar velocity
        velocity.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //fixar då om man har mindre fps
        velocity.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //5 m per sekund

        position += velocity;

        transform.position = position;


        //gravitation börjar långsamt och axar neråt
        Vector2 gravity = new Vector2(0, -0.9f); //minus så man ramlar ner
        velocity.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; 
        velocity.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        velocity += gravity * Time.deltaTime;

    }
}
