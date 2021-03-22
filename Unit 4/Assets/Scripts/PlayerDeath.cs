using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) // if player died go to thhe next scene
        {
            SceneManager.LoadScene("AfterDeath");
        }
    }

    public void FindNewTarget() // function to find an object with the tag "Player"
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}


