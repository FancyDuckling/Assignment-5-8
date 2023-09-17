using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public GameObject laserPrefab;
    public Transform gun1;
    public Transform gun2;
    float timer;
    float fireRate = 0.1f;


    // Update is called once per frame
    void Update()
    {
        //prata med kameran så spelaren har en plats i världen
        Vector2 direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        transform.up = direction;

        if (Input.GetMouseButton(0) && timer > fireRate)
        {
            timer = 0;
            Instantiate(laserPrefab, gun1.position, transform.rotation); //vilket object? laserPrefab´gör denna variabel
            //säg till den att den ska följa spelarens position
            Instantiate(laserPrefab, gun2.position, transform.rotation);
        }

        timer += Time.deltaTime;
    }
}
