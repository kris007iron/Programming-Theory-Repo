using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    //each string need to have to version english E and polish P
    //ENCAPSULATION
    public string nameE
    {
        get;
        private set;
    }
    public string nameP
    {
        get;
        private set;
    }
    public string doorsE
    {
        get;
        private set;
    }
    public string doorsP
    {
        get;
        private set;
    }
    public string examplesE
    {
        get;
        private set;
    }
    public string examplesP
    {
        get;
        private set;
    }
    protected TextMeshProUGUI infoT;
    protected GameObject panel;
    protected Button button;
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
        this.doorsP = doorsP;
        this.examplesE = examplesE;
        this.examplesP = examplesP;
    }
    
    public virtual void SetUpT()
    {
        infoT = GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>();
        panel = GameObject.Find("InfoPanel");        
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        panel.SetActive(true);
        infoT.text = null;
        infoT.text = ConfigureInfo(MainManager.Instance.language);
    }
}
