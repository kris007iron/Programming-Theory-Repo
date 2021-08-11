using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Car : MonoBehaviour
{
    //each string need to have to version english E and polish P
    public string nameE
    {
        get;
        protected set;
    }
    public string nameP
    {
        get;
        protected set;
    }
    public string doorsE
    {
        get;
        protected set;
    }
    public string doorsP
    {
        get;
        protected set;
    }
    public string examplesE
    {
        get;
        protected set;
    }
    public string examplesP
    {
        get;
        protected set;
    }
    public TextMeshProUGUI infoT;
    public GameObject panel;
    public virtual string ConfigureInfo(int language) // Abstratciotn mostly i dont need to add anything else but for two types of body i need to add extra info
    {
        string info = "";
        switch (language)
        {
            case 0:
                info = "Type: " + nameE + "\n" +
                    "Doors: " + doorsE + "\n" +
                    "Examples: " + examplesE + "\n";
                break;
            case 1:
                info = "Typ: " + nameP + "\n" +
                    "Drzwi: " + doorsP + "\n" +
                    "Przyk³ady: " + examplesP + "\n";
                break;
        }
        return info;
    }
    public void SetUp(string nameE, string nameP, string doorsE, string doorsP,string examplesE, string examplesP)
    {
        this.nameE = nameE;
        this.nameP = nameP;
        this.doorsE = doorsE;
        this.doorsP = doorsE;
        this.examplesE = examplesE;
        this.examplesP = examplesP;
    }
    
    public void SetUpT()
    {
        infoT = GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>();
        panel = GameObject.Find("InfoPanel");
        panel.SetActive(false);
    }
    public void OnClick()
    {
        panel.SetActive(true);
        infoT.text = null;
        infoT.text = ConfigureInfo(MainManager.Instance.language);
    }
}
