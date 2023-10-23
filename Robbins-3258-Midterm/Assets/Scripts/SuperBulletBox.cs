using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBulletBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * .5f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.bullets += 100;
            Destroy(gameObject);
        }
    }
}
