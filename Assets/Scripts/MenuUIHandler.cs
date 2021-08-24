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
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField nameInput;
    
    
    private void Start()
    {
        MainManager.Instance.LoadData();

    }

    public void StartNew()
    {
        ChangeName();
        SceneManager.LoadScene(1);
    }
    void ChangeName()
    {
        MainManager.Instance.ChangeName(nameInput.text);
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
