using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
=======
    [SerializeField] Text ScoreStatus; // Referentie naar het tekstobject waar het ticketaantal wordt weergegeven
    private int ticketCount = 0; // Huidig aantal tickets

    public void AddTickets()
    {
        ticketCount = ticketCount + 3; // Voeg 3 tickets toe
        Debug.Log(ticketCount);
    }

    private void Update()
    {
        ScoreStatus.GetComponent<Text>();
        ScoreStatus.text = "Tickets: " + ticketCount.ToString(); // Bijwerken van de tekst met het huidige ticketaantal
>>>>>>> c5dc653484453bad43eb4f3432602556a0d802bb
    }
}
