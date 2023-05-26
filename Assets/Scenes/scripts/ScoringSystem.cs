using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public int currentScore = 0;
    [SerializeField] Text ScoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PointCollider")
        {
            currentScore++;
            Debug.Log(currentScore);
        }
    }

    private void Update()
    {
      ScoreText.GetComponent<Text>();
        ScoreText.text = "Score: " + currentScore.ToString();
    }
}
