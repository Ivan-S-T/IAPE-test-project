using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float wheelLag = .1f;
    [SerializeField]
    private Transform wheel;
    [SerializeField]
    private float wheelRototSpeed = 10f;
    [SerializeField]
    private float RototSpeed = 10f;
    [SerializeField]
    private GameObject rocketPrefab;
    [SerializeField]
    private Transform launcher;

    private void Update()
    {
        MovePlayer();

        if (Input.GetKeyUp(KeyCode.Space))
        {
            LaunchRocket();
        }
    }

    private void MovePlayer()
    {
        float horizotalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Math.Abs(verticalInput) > wheelLag)
        {
            RotateWheel();
        }

        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizotalInput * RototSpeed * Time.deltaTime*(verticalInput+.5f));
    }

    private void RotateWheel()
    {
        wheel.transform.Rotate(Vector3.right * Time.deltaTime * wheelRototSpeed, Space.Self);
    }

    

    private void LaunchRocket()
    {
        Instantiate(rocketPrefab, launcher.position, launcher.rotation);
    }
}
