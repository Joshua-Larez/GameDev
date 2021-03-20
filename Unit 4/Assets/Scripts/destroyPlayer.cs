using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }
    public void Death()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
