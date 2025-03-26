using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    [SerializeField] private int agilityBonus = 5;

    public override int Attack()
    {
        Debug.Log("Goblin attack!");
        return base.Attack() + agilityBonus;
    }
}
