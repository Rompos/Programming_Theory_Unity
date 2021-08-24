using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; } // Encapsulation;
    public string playerName;
    public GameObject carGameObject;



    private void Awake()
    {
        Singleton();//Abstraction execution

    }
    private void Singleton()//Abstraction main
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeName(string name)
    {
        playerName = name;
    }

    public void ChangeCar(GameObject car)
    {
        carGameObject = car;
    }

    [System.Serializable]
    class SaveData
    {

        public string userName;
        public GameObject userCar;
    }

    public void SaveInfo()
    {
        SaveData data = new SaveData();

        data.userName = playerName;
        data.userCar = carGameObject;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        //This method is a reversal of the SaveColor method
        //It uses the method File.Exists to check if a.json file exists.
        //If it doesn’t, then nothing has been saved, so no further action is needed.
        //If the file does exist, then the method will read its content with File.ReadAllText: 
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            carGameObject = data.userCar;
            playerName = data.userName;
        }
    }

}
