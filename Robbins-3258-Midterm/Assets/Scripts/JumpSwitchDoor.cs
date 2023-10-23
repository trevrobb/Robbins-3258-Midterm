using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSwitchDoor : MonoBehaviour
{
    public static JumpSwitchDoor instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openTheDoor()
    {
        gameObject.SetActive(false);
    }
}
