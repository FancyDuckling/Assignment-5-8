using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{


    public float speed = 3;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Input bäst i update
    void Update()
    {
        
        
        //circle test
  
  

        if (Input.GetKey(KeyCode.W))
        { 
           float v = Input.GetAxisRaw("Vertical");
           GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
           float v = Input.GetAxisRaw("Vertical");
           GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            float h = Input.GetAxisRaw("Horizontal");
            GetComponent<Rigidbody2D>().velocity = new Vector2(h, 0) * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            float h = Input.GetAxisRaw("Horizontal");
            GetComponent<Rigidbody2D>().velocity = new Vector2(h, 0) * speed;
        }

        



        
    }
}
