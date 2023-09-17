using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3;
    public GameObject enemy;
    
    Transform target; //hitta spelaren
    Rigidbody2D rb20; // ref till enemy rigidbody

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; 
        rb20 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        rb20.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D other) //vad har kolliderat med oss
    {
        if (other.gameObject.GetComponent<Laser>() != null) //om vi träffar förstörs våra skott och enem
        {
            float x = UnityEngine.Random.Range(10, 10); //enemy spawnar åt olika håll 
            float y = UnityEngine.Random.Range(-10, -10);


            Instantiate(enemy, new Vector2(x, y), transform.rotation);
            Instantiate(enemy, new Vector2(-x, -y), transform.rotation);

            Invoke("Death", 0.01f);
            Destroy(other.gameObject);
            
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
