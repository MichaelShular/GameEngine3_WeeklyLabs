using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used as a spawn point for player
//
//Version 0.1
//-just Instantiate player if it doesnt exist 

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject player; 
    void Start()
    {
        //Spawn player character if it doesn't exist
        if (!GameObject.FindGameObjectWithTag("Player"))
        {
            Instantiate(player);
        }
    }
}
