using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

public class PickupObject : MonoBehaviour
{
    public TMP_Text displayText; //referent naar het tekstobject 
    public string[] words; // array met willekeurige woorden
    private bool isPickedUp = false;
    private float displayDuration = 5f;

    void OnTriggerEnter2D(Collider2D ander)
    {
        if (!isPickedUp && ander.gameObject.CompareTag("cloud"))  // Als het object dat je raakt getagd is 
        {
            string randomWord = words[Random.Range(0, words.Length)];
            displayText.text = randomWord;
            gameObject.SetActive(false);
            isPickedUp = true;
        }
    }
}
