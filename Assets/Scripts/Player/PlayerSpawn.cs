using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        if (!GameObject.FindGameObjectWithTag("Player"))
        {
            Instantiate(player);
        }
    }
}
