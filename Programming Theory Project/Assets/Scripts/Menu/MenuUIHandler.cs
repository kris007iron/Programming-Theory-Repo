using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Dropdown LanguageChoser;
    public TextMeshProUGUI title;
    // Start is called before the first frame update
    void Start()
    {        
        ChooseLanguage(MainManager.Instance.language);
        LanguageChoser.value = MainManager.Instance.language;
        LanguageChoser.onValueChanged.AddListener(ChooseLanguage);              
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChooseLanguage(int language)//abstraction
    {
        switch (language)
        {
            case 0:
                title.text = "Base types of cars body";
                break;
            case 1:
                title.text = "Podstawowe typy aut";
                break;
        }
    }
    public void StartB()
    {
        MainManager.Instance.language = LanguageChoser.value;
        SceneManager.LoadScene(1);       
    }
}
