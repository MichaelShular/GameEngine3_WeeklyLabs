using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script used for a tilemap to know can a random encounter trigger and when it does 
//
//Version 0.1
//-enable and disable bool to when random encounter happens
//-calculating how far player moved can then comparing it to 
//a randomly generated distance to see if encounter happens
//-when random encounter happens pass player game object to next scene but disable 
//certian components so player can be used 
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
        //when random encounter are enable
        if (canRandomEncounter)
        {
            //used to calculate distance traveled 
            totalDistanceTraveled += Vector3.Distance(player.transform.position, previousLoc);
            previousLoc = player.transform.position;
            //check when random encounter event should happen
            if (distanceForNextEncounter <= totalDistanceTraveled)
            {
                //disabling player game object components for main world scene
                player.GetComponent<PlayerMovement>().enabled = false;
                player.GetComponent<SpriteRenderer>().enabled = false;
                //passing information to next scene
                DontDestroyOnLoad(player);
                SceneManager.LoadScene("RandomEncounterScene"); 
            }
        }
        

    }

    //enable flag for random encounter 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        canRandomEncounter = true;
        player = GameObject.FindGameObjectWithTag("Player");
        //setting randomly distance for when next encounter happens 
        distanceForNextEncounter = Random.Range(5, 50);
    }

    //disable flag for random encounter 
    private void OnTriggerExit2D(Collider2D collision)
    {
        canRandomEncounter = false;
    }

}
