using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUV : Car
{
    // Start is called before the first frame update
    void Start()
    {
        SetUpT();
        SetUp("SUV", "SUV", "5 and 3 windows on side", "5 i 3 okna na stronê", "Chevy Tahoe and Porsche Cayenne", "Chevrolet Tahoe i Porsche Cayenne");
    }
}
