using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private string charName;
    private int level = 1;
    private int experience = 0;
    
    public string CharName => charName;

    public void GainXP(int amount)
    {
        experience += amount;
        Debug.Log(charName + " gained " + amount + " XP!");
        
        if (experience >= level * 10) 
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        level++;
        experience = 0;
        health += 10; 
        Debug.Log(charName + " leveled up to level " + level + "!");
    }
}
