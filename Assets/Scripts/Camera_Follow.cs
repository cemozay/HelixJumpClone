using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform ball;

    private Vector3 offset;

    public float speed;

    void Start()
    {
        offset = transform.position - ball.position;
    }

    void Update()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, offset + ball.position, speed);
        transform.position = newPosition;   
    }
}
