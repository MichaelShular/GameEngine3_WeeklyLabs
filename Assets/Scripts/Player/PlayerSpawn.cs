using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used as a spawn point for player
//
//Version 0.1
//-just Instantiate player if it doesnt exist 
//Version 0.2
//-check to see if player players last save position and loads it
public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector2 playerPosition;
    void Start()
    {
        //Spawn player character if it doesn't exist
        if (!GameObject.FindGameObjectWithTag("Player"))
        {
            GameObject temp = Instantiate(player);
            if (PlayerPrefs.HasKey("x-axis"))
            {
                LoadPosition();
                temp.transform.position = playerPosition;
            }
        }
    }
    
    //Loading player's x and y position
    void LoadPosition()
    {
        playerPosition = new Vector2(PlayerPrefs.GetFloat("x-axis"),
            PlayerPrefs.GetFloat("y-axis"));
    }
}
