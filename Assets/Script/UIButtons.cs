using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    // Hier wordt alle buttons naar een ander scene gestuurd
    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }


    public void InsertCoin()
    {
        SceneManager.LoadScene("Insert Coin");
    }

    //Hier verlaat je de applicatie.
    public void Quit()
    {
        Application.Quit();
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

}
