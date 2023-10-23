using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    public static GameManager instance;

    public int bullets;
    void Start()
    {
        score = 0;
        instance = this;

        bullets = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
