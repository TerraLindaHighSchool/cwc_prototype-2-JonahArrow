using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    void Start()
    {
        
    }

    void Update()
    {
        // When the game object crosses these bounds they are destroyed or cause a game over
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
