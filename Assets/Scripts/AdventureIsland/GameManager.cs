using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private TMPro.TextMeshProUGUI healthText;
    [SerializeField] private GameObject damageEffect;

    public void PlayerHit(int damage)
    {
        Debug.Log("Player hit with damage: " + damage);
        player.health -= damage;
        healthText.text = healthText.text.Remove(healthText.text.Length - 1);
        Instantiate(damageEffect, player.transform.position, Quaternion.identity);
        if (player.health <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over!");
        player.gameObject.SetActive(false);
        healthText.text = "Game Over!";
    }
    private void GameWin()
    {
        Debug.Log("You Win!");
        healthText.text = "You Win!";
    }

    public void AboveEnemyHit(Enemy enemy)
    {
        Debug.Log("Player hit enemy from above.");
        Instantiate(damageEffect, enemy.transform.position, Quaternion.identity);
        enemy.TakeDamage();
        GameWin();
    }
}
