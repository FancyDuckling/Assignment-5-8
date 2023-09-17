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
        //prata med kameran s� spelaren har en plats i v�rlden
        Vector2 direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        transform.up = direction;

        if (Input.GetMouseButton(0) && timer > fireRate)
        {
            timer = 0;
            Instantiate(laserPrefab, gun1.position, transform.rotation); //vilket object? laserPrefab�g�r denna variabel
            //s�g till den att den ska f�lja spelarens position
            Instantiate(laserPrefab, gun2.position, transform.rotation);
        }

        timer += Time.deltaTime;
    }
}
