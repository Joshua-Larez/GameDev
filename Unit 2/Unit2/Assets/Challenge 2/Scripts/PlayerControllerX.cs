using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    //update is called once per frame
    void Update()
    {
        //shoot dog everytime space is clicked
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}




    // I tried to make delay but dont know how this "onder" i have, but i dont know so i just left it for someone curios

// Update is called once per frame
//void Update()
//{
// On spacebar press, send dog
//if (Input.GetKeyDown(KeyCode.Space))
// {
// StartCoroutine(ShootDogDelay());
// }
//}

//IEnumerator ShootDogDelay()
//{
//yield return new WaitForSeconds(2);
//Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
//}
//}
