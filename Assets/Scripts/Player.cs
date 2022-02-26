using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;
    float horizontalAxis;
    float verticalAxis;

    private void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        float t = Time.fixedDeltaTime;
        transform.Translate(horizontalAxis * t, verticalAxis * t, 0);
    }
}
