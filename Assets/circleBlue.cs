using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleBlue : MonoBehaviour
{
    float speed = 5f;
        
   //0.05f; //detta blir en d�lig hastighet om man har f�rre frames men man kan l�sa med deltatime
    
    Vector2 position; //fixa en position

    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fr�n l�rare circle 
        if (Input.GetKeyDown(KeyCode.R)) //om man tar bort Down g�r den detta en g�ng per frame
        {
            Debug.Log("Player is realoading");
        }

        if (Input.GetButton("Jump"))//denna finns i inputmanager i unity s� den vet att den kllar p� space
        {
            Debug.Log("player is jumping");
        }

        //Joystick kan man inte ha true eller false f�r den kan luta lite grann
        //getaxis ger en mjuk �verg�ng, skarpare anv�nd axisraw
        position.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //fixar d� om man har mindre fps
        position.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //5 m per sekund

        transform.position = position;


        //velocity konstant movement �t ett h�ll 
        position.x += speed * Time.deltaTime;
        //acceleration 
        speed *= 1.1f;
        speed += speed * 1.1f * Time.deltaTime; //acceleration �ver tid


        //tar position och �kar velocity
        velocity.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //fixar d� om man har mindre fps
        velocity.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //5 m per sekund

        position += velocity;

        transform.position = position;


        //gravitation b�rjar l�ngsamt och axar ner�t
        Vector2 gravity = new Vector2(0, -0.9f); //minus s� man ramlar ner
        velocity.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; 
        velocity.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        velocity += gravity * Time.deltaTime;

    }
}
