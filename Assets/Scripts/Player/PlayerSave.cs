using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///This script is to add the player save functions to the UnityEvent
/// 
///Version 0.1
///-save players x and y location
///-added listener to OnSaveEvent
public class PlayerSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         SaveGameState.OnSaveEvent.AddListener(SavePosition);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SavePosition();
        }
    }
    void SavePosition()
    {
        PlayerPrefs.SetFloat("x-axis", this.transform.position.x);
        PlayerPrefs.SetFloat("y-axis", this.transform.position.y);
    }
}
