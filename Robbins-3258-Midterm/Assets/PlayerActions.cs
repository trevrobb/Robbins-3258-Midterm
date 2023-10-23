using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        { 
            Shoot();
        }
    }

    void Shoot()
    {
        if (GameManager.instance.bullets != 0)
        {
            
            GameObject InstBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody bulletRB = InstBullet.GetComponent<Rigidbody>();
            bulletRB.AddForce(transform.forward * 100f, ForceMode.Impulse);
            GameManager.instance.bullets--;

        }
    }
}
