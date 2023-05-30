using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TicketButton : MonoBehaviour
{
    public Text ticketCountText; // Referentie naar het tekstobject waar het ticketaantal wordt weergegeven
    private int ticketCount = 0; // Huidig aantal tickets

    private void Start()
    {
        UpdateTicketCountText();
    }

    public void AddTickets()
    {
        ticketCount += 3; // Voeg 3 tickets toe
        UpdateTicketCountText();
    }

    private void UpdateTicketCountText()
    {
        ticketCountText.text = "Tickets: " + ticketCount.ToString(); // Bijwerken van de tekst met het huidige ticketaantal
    }
}
