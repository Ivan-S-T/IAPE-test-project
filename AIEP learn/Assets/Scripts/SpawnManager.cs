using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnPortals;
    [SerializeField]
    private GameObject[] enemies;


    private int maxEnemyVal=30;
    private int portalToSpawn;
    private int enemiesOnScreen=0;
    private int totalSpawnedEnemies = 0;
    private int maxEnemiesOnScreen=5;
    private float startSpawn = 3f;
    private float repeatSpawn = 2f;

    public int EnemiesOnScreen
    {
        get => enemiesOnScreen;
        set => enemiesOnScreen = value >= 0 ? value : 0;
    }

    private void Start()
    {
        InvokeRepeating(nameof(GenerateEnemie), startSpawn, repeatSpawn);
    }

    private void Update()
    {
        if (totalSpawnedEnemies>=maxEnemyVal)
        {
            CancelInvoke();
        }
    }

    private void GenerateEnemie()
    {
        if (EnemiesOnScreen>=maxEnemiesOnScreen)
        {
            return;
        }
        portalToSpawn = Random.Range(0, spawnPortals.Length);
        int enemyToSpawn = Random.Range(0, enemies.Length);
        spawnPortals[portalToSpawn].GetComponent<Portal>().CreateEnemy(enemies[enemyToSpawn]);
        EnemiesOnScreen++;
        totalSpawnedEnemies++;
    }
}
