using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCoinDoor : MonoBehaviour
{
    public static SuperCoinDoor Instance;
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openTheDoor()
    {
        Destroy(gameObject);
    }
}
