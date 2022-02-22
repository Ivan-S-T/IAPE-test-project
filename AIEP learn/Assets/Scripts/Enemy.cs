using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IRobot
{
    protected Transform player;
    private GameObject spawnManager;

    protected float timeBetweenShoots = 3f;
    protected float timeOfNextShoot = 0f;

    [SerializeField]
    private int health;
    [SerializeField]
    private float figtDistance = 5f;
    [SerializeField]
    private float speed = 3f;

    public int Health
    {
        get => health;
        set => health = value > 0 ? value : 0;
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager");
    }

    private void Update()
    {
        ChasePlayer();
    }



    protected virtual void ChasePlayer()
    {
        var delayFromPlayer = player.position - transform.position;
        transform.LookAt(player);
        if (delayFromPlayer.sqrMagnitude <= figtDistance)
        {
            Attack();
        }
        else
        {
            transform.Translate(transform.forward * Time.deltaTime * speed, Space.Self);
        }
    }

    protected virtual void Attack()
    {
        
    }

    public void GetDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            spawnManager.GetComponent<SpawnManager>().EnemiesOnScreen--;
            Destroy(gameObject);
        }
    }

    protected bool CheckShootAbility()
    {
        if (Time.time < timeOfNextShoot)
        {
            return false;
        }
        timeOfNextShoot = Time.time + timeBetweenShoots;
        return true;
    }
}
