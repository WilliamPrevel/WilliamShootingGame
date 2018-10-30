using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SmallEnemy;
    public GameObject BigEnemy;

    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    IEnumerator SpawnTimer()
    {
        while (true)
        {
            Spawn();
            spawnBig();
            yield return new WaitForSeconds(1f);
        }
    }

    void Spawn()
    {
        float randomY = Random.Range(6f, 11f);
        float randomX = Random.Range(-8.4f, 9.4f);
        
        Instantiate(SmallEnemy, new Vector3(randomX, randomY, 1), Quaternion.identity);
    }

    void spawnBig()
    {
        float randomY = Random.Range(12f, 15f);
        float randomX = Random.Range(-10f, 14f);

        Instantiate(BigEnemy, new Vector3(randomX, randomY, 0), Quaternion.identity);
    }
}