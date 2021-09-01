using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sedan : Car
{
    // Start is called before the first frame update
    void Start()
    {
        SetUpT();
        SetUp("Sedan", "Sedan", "4/5 and trunk separated from the passengers by the rear seat(sometimes)",
            "4/5 i baga¿nik oddzielony od pasa¿erów tylnymi siedzeniami", "BMW 3-series and VW Jetta", "Seria 3 BMW i VW Jetta");
    }
    public override string ConfigureInfo(int language) // POLYMORPHISM
    {
        string info = "";
        switch (language)
        {
            case 0:
                info = "Type: " + nameE + "\n" +
                    "Doors: " + doorsE + "\n" +
                    "Examples: " + examplesE + "\n" +
                    "Most comon kind of car on the road \n";
                break;
            case 1:
                info = "Typ: " + nameP + "\n" +
                    "Drzwi: " + doorsP + "\n" +
                    "Przyk³ady: " + examplesP + "\n" +
                    "Najpopularniejszy typ aut na drogach \n";
                break;
        }
        return info;
    }
}
