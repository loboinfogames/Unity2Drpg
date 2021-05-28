using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTimer;
    public int spawnLimit;
    public int spawnID;

    private EnemyHealth enemyHealth;
    private int spawnNum;
    private float timer;

    void Awake()
    {
        enemyHealth = enemy.GetComponent<EnemyHealth>();
    }

    void Start()
    {
        spawnID = Random.Range(1, 20);
    }

    void Update()
    {
        timer += Time.deltaTime;

        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        if (spawnNum < spawnLimit)
        {
            if (timer > spawnTimer)
            {
                Instantiate(enemy, transform.position, transform.rotation);
                enemyHealth.spawnID = spawnID;
                timer = 0f;
                spawnNum++;
            }
        }
    }

    public void EnemyDestroyed()
    {
        spawnNum--;
    }
}