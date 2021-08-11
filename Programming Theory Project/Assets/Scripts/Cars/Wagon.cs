using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wagon : Car // INHERITANCE
{
    
    // Start is called before the first frame update
    void Start()
    {
        SetUpT();
        SetUp("Wagon", "Combi", "5 and 3 windows on side", "5 i 3 okna na stronê", "Audi Allroad and Volvo V70", "Audi Allroad i Vol");
        //ABSTRACTION i just put neacessary informations
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
                    "Usually models that also exist as sedans \n";
                break;
            case 1:
                info = "Typ: " + nameP + "\n" +
                    "Drzwi: " + doorsP + "\n" +
                    "Przyk³ady: " + examplesP + "\n" +
                    "Czêsto modele które wystêpuj¹ jako sedany \n";
                break;
        }
        return info;
    }
}
