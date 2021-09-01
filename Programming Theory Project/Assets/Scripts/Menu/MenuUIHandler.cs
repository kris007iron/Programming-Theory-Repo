using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Dropdown LanguageChoser;
    public TextMeshProUGUI title;
    public TextMeshProUGUI close;
    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.Instance.stloading == 0)
        {
            MainManager.Instance.LoadData();
            MainManager.Instance.stloading = 1;
        }        
        ChooseLanguage(MainManager.Instance.language);
        LanguageChoser.value = MainManager.Instance.language;
        LanguageChoser.onValueChanged.AddListener(ChooseLanguage);              
    }
    void ChooseLanguage(int language)//abstraction
    {
        switch (language)
        {
            case 0:
                title.text = "Base types of cars body";
                close.text = "Close";
                break;
            case 1:
                title.text = "Podstawowe typy aut";
                close.text = "Zamknij";
                break;
        }
        MainManager.Instance.language = language;
    }
    public void StartB()
    {
        MainManager.Instance.language = LanguageChoser.value;
        SceneManager.LoadScene(1);       
    }
    public void Close()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit;
#endif
    }
    private void OnApplicationQuit()
    {
        MainManager.Instance.SaveData();
    }
}
