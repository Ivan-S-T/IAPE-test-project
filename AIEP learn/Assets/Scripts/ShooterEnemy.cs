using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : Enemy //INHERITANSE
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private Transform launcer;

    protected override void Attack() //POLYMORPHISM
    {
        if (CheckShootAbility())
        {
            Instantiate(projectile, launcer.position, launcer.rotation);
        }
    }
}
