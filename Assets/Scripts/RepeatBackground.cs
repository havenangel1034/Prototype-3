using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    float objectSize;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        objectSize = gameObject.GetComponent<Renderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position.x < startPos.x - (objectSize / 2))
        {
            transform.position = startPos;
        }


    }
}
