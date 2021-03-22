using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player"); // find the player object
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; // to see where player is 

        enemyRb.AddForce(lookDirection * speed);// to go to the location of the player

        if(transform.position.y < -10) // destroy the enemy object if lower than -10 in vertical 
        {
            Destroy(gameObject);
        }
    }
}
