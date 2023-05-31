using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SomScript : MonoBehaviour
{
    //Een int waarde om het aantal vragen bij te houden
    int QuestionStreak = 1;

    // 4 Text variablen voor de buttons
    [SerializeField] Text ButtonOne;
    [SerializeField] Text ButtonTwo;
    [SerializeField] Text ButtonThree;
    [SerializeField] Text SomDisplay;

    //Een paar variablen om andere functies vanuit ScoringSystem (script) aan te kunnen roepen.
    private GameObject eventsystem;
    private ScoringSystem scoringSystem;

    //int waarden voor de sommen
    int RndSomTeken;
    int RndGetalOne;
    int RndGetalTwo;

    int RightAnswer;

    //booleans om een button de juiste te laten zijn.
    bool ButtonOneRight;
    bool ButtonTwoRight;
    bool ButtonThreeRight;

    //De start functie, deze wordt 1 keer op het begin uitgevoerd.
    private void Start()
    {
        //Hier zoeken wij naar een GameObject met de naam : "EventSystem"
        eventsystem = GameObject.Find("EventSystem");
        //Hier zoeken wij daar een component van.
        scoringSystem = eventsystem.GetComponent<ScoringSystem>();

        //Hier worden de Text components van de buttons gezocht.
        ButtonOne.GetComponent<Text>();
        ButtonTwo.GetComponent<Text>();
        ButtonThree.GetComponent<Text>();

        //Hier roepen wij een functie aan om ook daadwerkelijk wat te gaan laten gebeuren.
        GenerateSom();
    }

    void GenerateSom()
    {

        //Deze functie is bedoelt om alle andere functies (op volgorde) aan te roepen.

        UpdateSom();

        BerekenSom();

        ChangeButtons();

        GenerateWrongAnswers();
    }

    //Deze functie update de som door nieuwe waarden te geven. zo zorgen wij ervoor dat er elke keer een nieuwe som komt.
    void UpdateSom()
    {
        //Hier geven wij voor meerdere variabelen een random getal.
        RndSomTeken = Random.Range(1, 5);
        Debug.Log(RndSomTeken);

        RndGetalOne = Random.Range(1, 20);
        Debug.Log(RndGetalOne);

        RndGetalTwo = Random.Range(1, 20);
        Debug.Log (RndGetalTwo);
    }

    //Deze functie wordt gebruikt om het antwoord te bereken, en dat gebaseerd op een random teken ( +, - , * of /)
    void BerekenSom()
    {
        //Dit is een switch om uit te rekenen wat het juiste antwoord is.

        //Wij gebruiken een random getal om te bepalen welk som teken er wordt gebruikt.
        switch(RndSomTeken)
        {
            case 1:
                //Hier doe wij het eerste getal + het tweede getal.
                RightAnswer = RndGetalOne + RndGetalTwo;
                //Hier wordt de tekst boven aan de buttons veranderd, zodat de speler ook daadwerkelijk de hele som te zien krijgt.
                SomDisplay.text = $"{RndGetalOne} + {RndGetalTwo} = ...?";
                //Hier een debug om te testen of de som juist werdt weergegeven.
                Debug.Log($"{RndGetalOne} + {RndGetalTwo} = {RightAnswer}");
                break;

            case 2:
                //Hier doe wij het eerste getal - het tweede getal.
                RightAnswer = RndGetalOne - RndGetalTwo;
                SomDisplay.text = $"{RndGetalOne} - {RndGetalTwo} = ...?";
                Debug.Log($"{RndGetalOne} - {RndGetalTwo} = {RightAnswer}");
                break ;

            case 3:
                //Hier doe wij het eerste getal * het tweede getal.
                RightAnswer = RndGetalOne * RndGetalTwo;
                SomDisplay.text = $"{RndGetalOne} * {RndGetalTwo} = ...?";
                Debug.Log($"{RndGetalOne} * {RndGetalTwo} = {RightAnswer}");
                break;

            case 4:
                //Hier doe wij het eerste getal / het tweede getal.
                RightAnswer = RndGetalOne / RndGetalTwo;
                SomDisplay.text = $"{RndGetalOne} / {RndGetalTwo} = ...?";
                Debug.Log($"{RndGetalOne} / {RndGetalTwo} = {RightAnswer}");
                break;

            default:
                //Hier doe wij het eerste getal + het tweede getal. Om enige bugs te voorkomen.
                RightAnswer = RndGetalOne + RndGetalTwo;
                break;
        }


        
    }
    void ChangeButtons()
    {
        int rndButton = Random.Range(1, 4);

        //Hier wordt bepaald waar het juiste antwoord komt te staan (Dit is ook Random)
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
        //in deze if-statement worden verkeerde antwoorden gegenerate, om wel foute antwoorden te geven, die alsnog in de buurt komen.
        //Hebben wij de range factor aangepast op het goeie antwoord -10, of maximaal +10
        if (ButtonOneRight == true)
        {
            //Hier is de statement: Als Button 1 klopt, dan...
            //Daarom worden alle knoppen behalve 1 aangepast. (dit geld voor elke statement)
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

    //Deze functies worden gebruikt om de invoer te checken, en om te kijken of het de juiste is.
    public void ButtonOnePressed()
    {
        //Deze statement checkt of het het juiste antwoord was.
        if (ButtonOneRight == true)
        {
            //Zo ja, wordt er een ticket bij gedaam.
            scoringSystem.Tickets++;
        }
        Debug.Log(scoringSystem.currentScore);
        //Dan wordt er weer een functie aangeroepen, om terug te gaan.
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


    //Deze functie wordt gebruikt om bij te houden hoeveel vragen je hebt beantwoord.
    void GoBackToMain()
    {
        switch (QuestionStreak)
        {
            //In het geval van 1 of 2 vragen, wordt er 1 bij het variable op gedaan.
            case 1:
                QuestionStreak++;
                GenerateSom();
                break;
            case 2:
                QuestionStreak++;
                GenerateSom();
                break;
                //Bij 3 wordt het variable weer naar 1 gezet. en wordt een andere scene geladen.
            case 3:
                QuestionStreak = 1;
                SceneManager.LoadScene("Start Screen");
                break;
        }

    }

}

