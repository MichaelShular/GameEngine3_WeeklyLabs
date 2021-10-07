using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomEvents : MonoBehaviour
{
    public bool canRandomEncounter;
    public float distanceForNextEncounter;
    private GameObject player;
    private Vector3 previousLoc;
    public float totalDistanceTraveled = 0;

    private void Start()
    {
        canRandomEncounter = false;
    }


    private void FixedUpdate()
    {
        if (canRandomEncounter)
        {
            totalDistanceTraveled += Vector3.Distance(player.transform.position, previousLoc);
            previousLoc = player.transform.position;
            if (distanceForNextEncounter <= totalDistanceTraveled)
            {
                player.GetComponent<PlayerMovement>().enabled = false;
                player.GetComponent<SpriteRenderer>().enabled = false;
                DontDestroyOnLoad(player);
                SceneManager.LoadScene("RandomEncounterScene"); 
            }
        }
        

    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        canRandomEncounter = true;
        player = GameObject.FindGameObjectWithTag("Player");
        distanceForNextEncounter = Random.Range(5, 50);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canRandomEncounter = false;
    }
}
