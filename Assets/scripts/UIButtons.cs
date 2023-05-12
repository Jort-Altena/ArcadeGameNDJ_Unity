using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void InsertCoin()
    {
        SceneManager.LoadScene("Insert Coin");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
