using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(transform.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.score += 100;
            Debug.Log(GameManager.instance.score);
            Destroy(gameObject);

        }
    }
}
