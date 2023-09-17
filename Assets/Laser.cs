using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject explosion;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2); //(OBS litet g) ta bort mig själv om 2 sek dvs laser tas bort 
    }

    // Update is called once per frame
    void Update()
    {
        //alternativ 1
        //transform.position += new Vector3(0, 5) * Time.deltaTime; //laser kmr åka uppåt me speed 5

        //nu vill vi ha att den ska kolla var är spelarens upp
        transform.position += transform.up * 5 * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject newExplosion = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(newExplosion, 1);
    }
}
