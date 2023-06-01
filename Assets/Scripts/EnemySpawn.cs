using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab
    public float spawnInterval = 2f; // Interval between spawns
    public float spawnDistance = 10f; // Distance from the center to spawn

    private Transform playerTransform; // Reference to the player's transform

    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;

        // Start spawning enemies
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while(true)
        {
            // Calculate spawn positions
            Vector3 spawnPositionLeft = playerTransform.position + new Vector3(-spawnDistance, 0, 0);
            Vector3 spawnPositionRight = playerTransform.position + new Vector3(spawnDistance, 0, 0);

            // Spawn enemies
            SpawnEnemy(spawnPositionLeft);
            SpawnEnemy(spawnPositionRight);

            // Wait for next spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnEnemy(Vector3 spawnPosition)
    {
        // Instantiate a new enemy at the spawn position
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Set the enemy's target to the player
        EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
        enemyMovement.player = playerTransform;
    }
}
