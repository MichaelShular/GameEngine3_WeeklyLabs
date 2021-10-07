using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Has button fuctions that are in the start scene 
//
//Version 0.1
//-load main world scene
//-can quit the application
public class MenuButtonManager : MonoBehaviour
{
    public void loadMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void closeProgram()
    {
        Application.Quit();
    }
}
