using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour
{

    public GameObject coin;
  
    Transform target; //hitta spelaren
    GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        manager.AddPoint();
        Death();
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
