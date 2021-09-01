using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatchback : Car
{
    // Start is called before the first frame update
    void Start()
    {
        SetUpT();
        SetUp("Hatchback", "Hatchback", "2/4 or 3/5 and 2 windows on sides excluding small side windows",
            "2/4 albo 3/5 i 2 szyby po bokach wy³¹czaj¹c te w rogach", "Ford Focus and VW Golf", "Fors Focus i VW Golf");
    }
}
