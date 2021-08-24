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

public class RaceUIHandler : MonoBehaviour
{
    public Text nameInput;
    public GameObject selectCar;

    private void Start()
    {
        //MainManager.Instance.LoadData();
        nameInput.text = "Player's Name : " + MainManager.Instance.playerName.ToString();
        selectCar = MainManager.Instance.carGameObject;
        

    }

    public void StartNew()
    {
        ChangeName();//abstraction run
        SceneManager.LoadScene(3);
    }
    void ChangeName()//abstraction main
    {
        MainManager.Instance.ChangeName(nameInput.text);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
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