using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private float followSpeed = 20f;
    [SerializeField]
    private float rotSpeed = 20f;
    [SerializeField]
    private Transform followTarget;
    Quaternion camRotation;

    private void Start()
    {
        //camRotation = transform.rotation;
    }

    private void LateUpdate()
    {
        Vector3 pos = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        transform.position = pos;



        // camRotation.y = Mathf.Lerp(transform.rotation.y, followTarget.rotation.y, rotSpeed*Time.deltaTime);
        camRotation = transform.rotation;
        camRotation.y = followTarget.rotation.y;
        transform.rotation = camRotation;


    }
}
