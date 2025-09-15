using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject[] cubePrefabs; //assign 4 prefabs here

    [Header("Spawn points")]
    public Transform[] spawnPoints; //assign 4 spawn points here

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true) {
            GameObject prefab = cubePrefabs[Random.Range(0, cubePrefabs.Length)]; //this picks a random prefab

            Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)]; //this picks a random spawn point

            Instantiate(prefab, point.position, point.rotation); //this spawns the prefab at the spawn point

            yield return new WaitForSeconds(1f);

        }
    }
}
