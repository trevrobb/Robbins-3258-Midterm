using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;

    public static GameManager instance;
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] TextMeshProUGUI _bulletsText;


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
        _scoreText.text = "Score: " + score;
        _bulletsText.text = "Bullets: " + bullets;

    }
}
