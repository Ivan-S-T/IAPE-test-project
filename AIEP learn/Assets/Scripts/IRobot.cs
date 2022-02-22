using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRobot 
{
    public int Health { get; set; }

    public void GetDamage(int damage);
}
