using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TicketButton : MonoBehaviour
{
    [SerializeField] Text ScoreStatus; // Referentie naar het tekstobject waar het ticketaantal wordt weergegeven
    private int ticketCount = 0; // Huidig aantal tickets

    public void AddTickets()
    {
        Debug.Log(ticketCount);
        ticketCount = ticketCount + 3; // Voeg 3 tickets toe
    }

    private void Update()
    {
        ScoreStatus.GetComponent<Text>();
        ScoreStatus.text = "Tickets: " + ticketCount.ToString(); // Bijwerken van de tekst met het huidige ticketaantal
    }
}
