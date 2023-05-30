using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SomScript : MonoBehaviour
{

    int QuestionStreak = 1;

    [SerializeField] Text ButtonOne;
    [SerializeField] Text ButtonTwo;
    [SerializeField] Text ButtonThree;
    [SerializeField] Text SomDisplay;

    private GameObject eventsystem;
    private ScoringSystem scoringSystem;

    int RndSomTeken;
    int RndGetalOne;
    int RndGetalTwo;

    int RightAnswer;

    bool ButtonOneRight;
    bool ButtonTwoRight;
    bool ButtonThreeRight;

    private void Start()
    {
        eventsystem = GameObject.Find("EventSystem");
        scoringSystem = eventsystem.GetComponent<ScoringSystem>();

        ButtonOne.GetComponent<Text>();
        ButtonTwo.GetComponent<Text>();
        ButtonThree.GetComponent<Text>();


        GenerateSom();
    }

    void GenerateSom()
    {
        UpdateSom();

        BerekenSom();

        ChangeButtons();

        GenerateWrongAnswers();
    }

    void UpdateSom()
    {
        RndSomTeken = Random.Range(1, 5);
        Debug.Log(RndSomTeken);

        RndGetalOne = Random.Range(1, 20);
        Debug.Log(RndGetalOne);

        RndGetalTwo = Random.Range(1, 20);
        Debug.Log (RndGetalTwo);
    }
    void BerekenSom()
    {
        switch(RndSomTeken)
        {
            case 1:
                RightAnswer = RndGetalOne + RndGetalTwo;
                SomDisplay.text = $"{RndGetalOne} + {RndGetalTwo} = ...?";
                Debug.Log($"{RndGetalOne} + {RndGetalTwo} = {RightAnswer}");
                break;

            case 2:
                RightAnswer = RndGetalOne - RndGetalTwo;
                SomDisplay.text = $"{RndGetalOne} - {RndGetalTwo} = ...?";
                Debug.Log($"{RndGetalOne} - {RndGetalTwo} = {RightAnswer}");
                break ;

            case 3:
                RightAnswer = RndGetalOne * RndGetalTwo;
                SomDisplay.text = $"{RndGetalOne} * {RndGetalTwo} = ...?";
                Debug.Log($"{RndGetalOne} * {RndGetalTwo} = {RightAnswer}");
                break;

            case 4:
                RightAnswer = RndGetalOne / RndGetalTwo;
                SomDisplay.text = $"{RndGetalOne} / {RndGetalTwo} = ...?";
                Debug.Log($"{RndGetalOne} / {RndGetalTwo} = {RightAnswer}");
                break;

            default:
                RightAnswer = RndGetalOne + RndGetalTwo;
                break;
        }


        
    }
    void ChangeButtons()
    {
        int rndButton = Random.Range(1, 4);

        if (rndButton == 1)
        {
            ButtonOne.text = RightAnswer.ToString();
            ButtonOneRight = true;
        }
        else if (rndButton == 2)
        {
            ButtonTwo.text = RightAnswer.ToString();
            ButtonTwoRight = true;
        }
        else if (rndButton == 3)
        {
            ButtonThree.text = RightAnswer.ToString();
            ButtonThreeRight = true;
        }
    }
    void GenerateWrongAnswers()
    {

        if (ButtonOneRight == true)
        {
            ButtonTwo.text = Random.Range(RightAnswer - 15, RightAnswer + 20).ToString();
            ButtonThree.text = Random.Range(RightAnswer - 15, RightAnswer + 20).ToString();
        }
        else if (ButtonTwoRight == true)
        {
            ButtonOne.text = Random.Range(RightAnswer - 15, RightAnswer + 20).ToString();
            ButtonThree.text = Random.Range(RightAnswer - 15, RightAnswer + 20).ToString();
        }
        else if (ButtonThreeRight == true)
        {
            ButtonOne.text = Random.Range(RightAnswer - 15, RightAnswer + 20).ToString();
            ButtonTwo.text = Random.Range(RightAnswer - 15, RightAnswer + 20).ToString();
        }

    }

    public void ButtonOnePressed()
    {
        if (ButtonOneRight == true)
        {
            scoringSystem.Tickets++;
        }
        Debug.Log(scoringSystem.currentScore);
        GoBackToMain();
    }

    public void ButtonTwoPressed()
    {
        if (ButtonTwoRight == true)
        {
            scoringSystem.Tickets++;
        }
        Debug.Log(scoringSystem.currentScore);
        GoBackToMain();
    }

    public void ButtonThreePressed()
    {
        if (ButtonThreeRight == true)
        {
            scoringSystem.Tickets++;
        }
            Debug.Log(scoringSystem.currentScore);
        GoBackToMain();
    }

    void GoBackToMain()
    {

        switch (QuestionStreak)
        {
            case 1:
                QuestionStreak++;
                GenerateSom();
                break;
            case 2:
                QuestionStreak++;
                GenerateSom();
                break;
            case 3:
                QuestionStreak = 1;
                SceneManager.LoadScene("Start Screen");
                break;
        }



    }


}

