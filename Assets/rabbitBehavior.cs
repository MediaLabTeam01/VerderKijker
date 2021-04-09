using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbitBehavior : MonoBehaviour
{
    Vector3 start;
    public GameObject destination;

    void Start()
    {
        start = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(start, destination.transform.position, Mathf.PingPong(Time.time * 0.1f, 1.0f));
    }
}

