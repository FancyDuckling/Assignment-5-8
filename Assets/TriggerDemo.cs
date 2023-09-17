using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDemo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //OBJECT ÖVERLAPPAR OCH TRIGGAR NÅT
    {
        Debug.Log("Trigger Happy" + collision.gameObject.name); //man kan döpa om collision till tex other för att hålla koll på vad som kommer in i trigger area
    }

    private void OnCollisionEnter2D(Collision2D collision) //HUR DOM KOLLIDERAR, HUR HÅRT KROCKAR VI
    {
        
    }
}
