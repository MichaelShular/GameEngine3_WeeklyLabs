using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

///This script to create Unityevent so saving events can connect so all
///saving happen in one button press
/// 
///Version 0.1
///-A event to save which is connected to a button 
public class SaveGameState : MonoBehaviour
{
    public static UnityEvent OnSaveEvent = new UnityEvent();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Save();
        }
    }
    public void Save()
    {
        OnSaveEvent.Invoke();
        PlayerPrefs.Save();
    }
}
