using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInstantiate : MonoBehaviour
{
    //variable voor de prefabs.
    [SerializeField] GameObject map;
    [SerializeField] GameObject mapTwo;
    [SerializeField] GameObject mapThree;
    //Locatie van waar ze moeten gaan spawnen
    [SerializeField] int mapLocation;
    float locationChanger = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn een map telkens als je een keycode space gebruikt
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 2; i++)
            {
                //Met deze methode kan je de mappen random ipv in orde spawnen
                int randomNumber = Random.Range(1, 4);
                switch (randomNumber)
                {
                    case 1:
                        Vector2 mapPosition = new Vector2(locationChanger, 0.0f); // Je geeft aan de locatie van de map
                        locationChanger = locationChanger + mapLocation; //Hier geef je aan dat de x positie telkens wordt veranderd zodat ze niet overlappen
                        Instantiate(map, mapPosition, Quaternion.identity); //Hier spawn je dus de prefab
                        break;

                    case 2:
                        mapPosition = new Vector2(locationChanger, 0.0f);
                        locationChanger = locationChanger + mapLocation;
                        Instantiate(mapTwo, mapPosition, Quaternion.identity);
                        break;
                    case 3:
                        mapPosition = new Vector2(locationChanger, 0.0f);
                        locationChanger = locationChanger + mapLocation;
                        Instantiate(mapThree, mapPosition, Quaternion.identity);
                        break;
                }
            }
        }
    }
}
