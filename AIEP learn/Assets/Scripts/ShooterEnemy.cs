using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : Enemy
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private Transform launcer;


    protected override void Attack()
    {
        base.Attack();
        if (Time.time < timeOfNextShoot)
        {
            return;
        }
        timeOfNextShoot = Time.time + timeBetweenShoots;
        Instantiate(projectile, launcer.position, launcer.rotation);
        
    }
}
