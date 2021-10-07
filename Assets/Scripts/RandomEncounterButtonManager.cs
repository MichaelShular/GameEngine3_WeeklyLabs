using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomEncounterButtonManager : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadGameWorld()
    {
        DontDestroyOnLoad(player);
        SceneManager.LoadScene("Main");
    }
}
