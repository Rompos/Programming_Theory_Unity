using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.IO;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI

public class CarUIHandler : MonoBehaviour
{
    
    public GameObject selectCar;
    public Text nameInput;

    private void Start()
    {
        //MainManager.Instance.LoadData();
        selectCar = MainManager.Instance.carGameObject;
        nameInput.text =  MainManager.Instance.playerName.ToString() + " Select Car !";

    }

    private void Update()
    {
        if (selectCar != MainManager.Instance.carGameObject)
        {
            selectCar = MainManager.Instance.carGameObject;
            
        }
    }

    public void StartNew()
    {
        ChangeCar(); //abstraction run
        SceneManager.LoadScene(2);//i have the same line of code in CarSelector script in the canvas confirm button
    }
    void ChangeCar()//abstraction main
    {
        MainManager.Instance.ChangeCar(selectCar);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
