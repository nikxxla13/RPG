using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyStats;
    
    void Start()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.name;
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        playerHealth.text = player.health.ToString();
        enemyStats.text = enemy.health.ToString();
    }

    public void DoRound()
    {
        enemy.GetHit(player.Weapon);
        player.Weapon.ApplyEffect(enemy);
        
        if (enemy.health <= 0)
        {
            Debug.Log(enemy.name + " defeated!");
            player.GainXP(10);
            enemy = SpawnNewEnemy();
        }
        else
        {
            // Ienaidnieks uzbrūk
            int enemyDamage = enemy.Attack();
            player.GetHit(enemyDamage);
            enemy.Weapon.ApplyEffect(player);
        }

        UpdateHealth();
    }

    public void OnShieldButtonPressed()
{
    player.ActivateShield();
}

    private Enemy SpawnNewEnemy()
    {
        return new Enemy();
    }
}
