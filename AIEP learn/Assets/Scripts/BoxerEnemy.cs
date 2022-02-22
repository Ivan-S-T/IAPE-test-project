using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxerEnemy : Enemy
{

    protected override void Attack()
    {
        if (CheckShootAbility())
        {
            HandleAttack();
        }

    }

    private void HandleAttack()
    {
        // hit player;
    }
}
