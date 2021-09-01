using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public int language
    {         
        get;
        set;//encapsulation
        
    }    
    public int stloading = 0;
    private void Awake()
    {
        if(Instance != null)

        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    [System.Serializable]
    class DataToSave
    {
        public int language;
        public DataToSave(int language)
        {
            this.language = language;
        }
    }
    public void SaveData()
    {
        DataToSave data = new DataToSave(language);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/data.json", json);
    }
    public void LoadData()
    {
        string path = Application.persistentDataPath + "/data.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DataToSave data = JsonUtility.FromJson<DataToSave>(json);
            language = data.language;
        }
    }
}
