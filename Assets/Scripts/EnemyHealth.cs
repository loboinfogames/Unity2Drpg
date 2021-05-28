using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public int spawnID;

    private EnemyMovement enemyMovement;
    private EnemySpawn enemySpawn;

    void Awake()
    {
        enemyMovement = GetComponent<EnemyMovement>();
    }

    void OnEnable()
    {
        currentHealth = startingHealth;
    }

    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
       
        Destroy(gameObject);
    }
}
