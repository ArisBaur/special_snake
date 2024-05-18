using UnityEngine;
using UnityEngine.AI;

public class ZombieSpawner : MonoBehaviour
{
    // The zombie prefab to spawn
    [SerializeField] GameObject zombiePrefab;

    // The time between zombie spawns
    [SerializeField] float spawnInterval = 30f;

    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            GameObject enemy = Instantiate(zombiePrefab, transform.position, Quaternion.identity);
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}