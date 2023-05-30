using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInstantiate : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] GameObject mapTwo;
    [SerializeField] GameObject mapThree;
    [SerializeField] int mapLocation;
    float locationChanger = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //int randomNumber = Random.Range(1, 4);
        //switch (randomNumber)
        //{
           
        //    case 1:
        //        Vector2 mapPosition = new Vector2(locationChanger, 0.0f);
        //        locationChanger = locationChanger + mapLocation;
        //        Instantiate(map, mapPosition, Quaternion.identity);
        //        break;

        //    case 2:
        //        mapPosition = new Vector2(locationChanger, 0.0f);
        //        locationChanger = locationChanger + mapLocation;
        //        Instantiate(mapTwo, mapPosition, Quaternion.identity);
        //        break;
        //    case 3:
        //        mapPosition = new Vector2(locationChanger, 0.0f);
        //        locationChanger = locationChanger + mapLocation;
        //        Instantiate(mapThree, mapPosition, Quaternion.identity);
        //        break;


       // }
    }
}
