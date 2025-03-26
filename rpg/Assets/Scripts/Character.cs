using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] private Weapon weapon;
    private bool shieldActive = false;
    
    public Weapon Weapon => weapon;

    public virtual int Attack()
    {
        return weapon.GetDamage();
    }

    public void GetHit(int damage)
    {
        Debug.Log(name + " starting health: " + health);

        if (shieldActive)
        {
            Debug.Log(name + " blocked some damage!");
            damage /= 2;  
            shieldActive = false; 
        }

        health -= damage;
        Debug.Log(" health after hit: " + health);
    }

    public void GetHit(Weapon weapon)
    {
        Debug.Log(name + " starting health: " + health);
        health -= weapon.GetDamage();
        Debug.Log(" health after hit by " + weapon.name + ": " + health);
    }

    public void ActivateShield()
    {
        shieldActive = true;
        Debug.Log(name + " activated shield!");
    }

    public void Shout()
    {
        Debug.Log(" I AM " + name.ToUpper());
    }
}

