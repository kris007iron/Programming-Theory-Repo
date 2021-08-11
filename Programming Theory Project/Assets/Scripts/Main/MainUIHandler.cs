using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    public TextMeshProUGUI ExitB;
    public TextMeshProUGUI ClosePanelB;    
    void Start()
    {
        LoadUILanguage(); 
    }
    void LoadUILanguage() //Abstraction
    {
        switch (MainManager.Instance.language)
        {
            case 0:
                ExitB.text = "Exit";
                ClosePanelB.text = "Close";
                break;
            case 1:
                ExitB.text = "Wyjœcie";
                ClosePanelB.text = "Zamknij";
                break;
        }
    }    
    void Update()
    {
        
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CloseInfo(GameObject info)
    {
        info.SetActive(false);
    }
}
