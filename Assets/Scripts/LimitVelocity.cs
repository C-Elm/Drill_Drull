using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitVelocity : MonoBehaviour
{
    public float maxFallSpeed = 10f;

    private Rigidbody2D localRgb;

    void Start()
    {
        localRgb = GetComponent<Rigidbody2D>();
    }
 

    void FixedUpdate()
    {
        if (localRgb.velocity.magnitude > maxFallSpeed)
            localRgb.velocity = Vector3.ClampMagnitude(localRgb.velocity, maxFallSpeed);
    }
}
