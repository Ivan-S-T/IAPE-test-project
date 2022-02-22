using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private float followSpeed = 20f;
    [SerializeField]
    private float rotSpeed = 20f;
    [SerializeField]
    private Transform followTarget;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, followTarget.rotation, rotSpeed * Time.deltaTime);
    }
}
