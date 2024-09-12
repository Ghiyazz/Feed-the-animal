using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;  // Adjust this for the left side limit
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit (moving left out of bounds)
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottomLimit (falling down out of bounds)
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}


