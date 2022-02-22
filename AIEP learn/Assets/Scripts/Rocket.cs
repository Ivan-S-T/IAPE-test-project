using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private float speed = 10f;
    private float lifeTime = 2f;

    [SerializeField]
    private int damage = 10;

    private void Start()
    {
        StartCoroutine("SelfDestroy");
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed);
    }

    IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        
        var script = other.gameObject.GetComponent<IRobot>();
        if (script!=null)
        {
            script.GetDamage(damage);

        }


        Destroy(gameObject);

    }
}
