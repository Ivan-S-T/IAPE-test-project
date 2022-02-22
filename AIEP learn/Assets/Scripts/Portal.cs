using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPosition;

   public void CreateEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPosition.position, spawnPosition.rotation);
    }
}
