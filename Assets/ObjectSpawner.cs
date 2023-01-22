using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int totalObjects = 15;
    public Vector3 spawnAreaSize = Vector3.one;

    void Start()
    {
        Bounds spawnBounds = new Bounds(transform.position, spawnAreaSize);

        for (int i = 0; i < totalObjects; i++)
        {
            Vector3 randomPos = new Vector3(
                Random.Range(spawnBounds.min.x, spawnBounds.max.x),
                Random.Range(spawnBounds.min.y, spawnBounds.max.y),
                Random.Range(spawnBounds.min.z, spawnBounds.max.z)
            );

            Instantiate(prefab, randomPos, transform.rotation);
        }
    }
}
