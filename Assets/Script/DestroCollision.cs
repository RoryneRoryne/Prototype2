using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroCollision : MonoBehaviour
{
    int scores;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //whenever collider hit something, it will destroy the object
    private void OnTriggerEnter(Collider other) 
    {
        //hanya menghancurkan object yang tidak bernama player
        //only destroy gameObject if it's not named player
        if (other.gameObject.name != "Player")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            scores++;
            Debug.Log("scores = " + scores);
        }
    }
}
