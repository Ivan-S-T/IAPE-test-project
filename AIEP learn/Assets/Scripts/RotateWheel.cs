using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    private float rotSpeed = 30f;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.right * rotSpeed * Time.fixedDeltaTime);
    }
}
