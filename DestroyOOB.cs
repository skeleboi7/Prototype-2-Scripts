using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float xBound = 30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < lowerBound || transform.position.x < - xBound || transform.position.x > xBound)
        {
            Destroy(gameObject);
        }
    }
}
