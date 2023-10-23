using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorBoulder : MonoBehaviour
{
    Rigidbody rb;
    bool addedForce;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       addedForce = false;
       rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
            if (DoorBoulderDoor.instance.doorIsOpened)
            {
                if (!addedForce)
                {
                    rb.isKinematic = false;
                    rb.AddForce(-Vector3.right * 50f, ForceMode.Impulse);
                    addedForce = true;
                }
            }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
