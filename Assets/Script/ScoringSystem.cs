using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    [SerializeField] int playerScore = 0;
    Text text;
    string playerNameKey = "PlayerName";
    [SerializeField] string currentName = "Jort";
    [SerializeField] string newName = "Nicole";
    [SerializeField] int currentScore = 0;
    private int highScore;
    [SerializeField] bool deleteScore = false;


    private void Start()
    {
        text = GetComponent<Text>();
        if (deleteScore == true)
        {
            PlayerPrefs.DeleteAll();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PointCollider")
        {
            currentScore++;
        }
    }

    private void Update()
    {
     
        scoreText.text = "Score: " + currentScore.ToString();
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.GetInt(playerNameKey, highScore);
            PlayerPrefs.SetInt(playerNameKey, highScore);
            print("wegouiqhtoqf");
        }
        string scoreString = Convert.ToString(PlayerPrefs.GetInt(playerNameKey, highScore));
        highScoreText.text = "High Score: " + scoreString;
    }
}

