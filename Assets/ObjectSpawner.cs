using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab; // The object you want to spawn
    public int totalObjects = 15; // The total number of objects to spawn
    public Vector3 spawnAreaSize = Vector3.one; // The size of the area in which to spawn the objects

    void Start()
    {
        // Calculate the bounds of the spawn area
        Bounds spawnBounds = new Bounds(transform.position, spawnAreaSize);

        // Spawn the objects
        for (int i = 0; i < totalObjects; i++)
        {
            // Choose a random position within the spawn bounds
            Vector3 randomPos = new Vector3(
                Random.Range(spawnBounds.min.x, spawnBounds.max.x),
                Random.Range(spawnBounds.min.y, spawnBounds.max.y),
                Random.Range(spawnBounds.min.z, spawnBounds.max.z)
            );

            // Spawn the object
            Instantiate(prefab, randomPos, transform.rotation);
        }
    }
}
