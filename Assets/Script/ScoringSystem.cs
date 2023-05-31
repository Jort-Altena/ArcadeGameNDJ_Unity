using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    //hier zijn alle variable gemaakt voor de score
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    [SerializeField] int playerScore = 0;
    Text text;
    string playerNameKey = "PlayerScore";
    [SerializeField] int currentScore = 0;
    private int highScore;
    [SerializeField] bool deleteScore = false;


    private void Start()
    {
        // hier haal ik de text component op
        text = GetComponent<Text>();
        //hier reset ik de score als ik het wil
        if (deleteScore == true)
        {
            PlayerPrefs.DeleteAll();
        }

    }
    //Als de collision wordt getriggerd, dan komt er een punt erbij
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PointCollider")
        {
            currentScore++;
        }
    }
    //Hier wordt gebruikt gemaakt over playerprefs. 
    // Het score wordt opgeslagen als de score groter is dan de highscore.
    private void Update()
    {
     
        scoreText.text = "Score: " + currentScore.ToString();
        if (currentScore > PlayerPrefs.GetInt(playerNameKey,highScore))
        {
            highScore = currentScore;
            PlayerPrefs.GetInt(playerNameKey, highScore);// Hier haal je het op
            PlayerPrefs.SetInt(playerNameKey, highScore); // Hier store je de score in playerPrefs

        }
        string scoreString = Convert.ToString(PlayerPrefs.GetInt(playerNameKey, highScore)); // hier convert je het naar een string
        highScoreText.text = "High Score: " + scoreString;
    }
}

