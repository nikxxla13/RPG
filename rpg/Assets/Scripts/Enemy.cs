using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] protected int aggression = 10;
    [SerializeField] private Weapon enemyWeapon;  

    public override int Attack()
    {
        return enemyWeapon.GetDamage() + aggression / 10;
    }
}
