using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDemo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //OBJECT �VERLAPPAR OCH TRIGGAR N�T
    {
        Debug.Log("Trigger Happy" + collision.gameObject.name); //man kan d�pa om collision till tex other f�r att h�lla koll p� vad som kommer in i trigger area
    }

    private void OnCollisionEnter2D(Collision2D collision) //HUR DOM KOLLIDERAR, HUR H�RT KROCKAR VI
    {
        
    }
}
