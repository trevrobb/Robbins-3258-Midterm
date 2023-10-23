using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBoulderDoor : MonoBehaviour
{
    public static DoorBoulderDoor instance;
    public bool doorIsOpened;
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
        doorIsOpened = true;
        gameObject.SetActive(false);
    }


}
