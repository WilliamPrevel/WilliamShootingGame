using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour



{ // Prefab to spawn
    public GameObject spawnee;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    IEnumerator SpawnTimer()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(1f);
        }
    }

    void Spawn()
    {
        float randomY = Random.Range(8f, 12f);
        float randomX = Random.Range(-8.4f, 9.4f);
        //for (int i = 0; i < 1; i++)

        Instantiate(spawnee, new Vector3(randomX, randomY, 1), Quaternion.identity);
    }
}