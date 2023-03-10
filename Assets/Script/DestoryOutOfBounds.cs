using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    float topBorder =35f;
    float botBorder =-16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when carrot passed certain poin, it will despawn.
        if (transform.position.z > topBorder)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < botBorder)
        {
            //when animal passed certain poin, it will despawn and show  game over message as debug.log
            // Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
