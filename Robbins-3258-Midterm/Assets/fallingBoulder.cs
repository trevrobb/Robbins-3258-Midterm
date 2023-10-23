using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBoulder : MonoBehaviour
{
    Rigidbody rb;
    public static fallingBoulder instance;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void useGravity()
    {
        rb.useGravity = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ResetLevelHere");
        }
    }
}
