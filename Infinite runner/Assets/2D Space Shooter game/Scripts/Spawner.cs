using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SmallEnemy;
    public GameObject BigEnemy;

    public GameObject SmartEnemy;

    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    IEnumerator SpawnTimer()
    {
        while (true)
        {
            Spawn();
            SpawnBig();
            SpawnSmart();
            yield return new WaitForSeconds(4f);
        }
    }

    void Spawn()
    {
        float randomY = Random.Range(6f, 11f);
        float randomX = Random.Range(-8.4f, 9.4f);

        Instantiate(SmallEnemy, new Vector3(randomX, randomY, 1), Quaternion.identity);
        

    }

    void SpawnBig()
    {
        float randomY = Random.Range(12f, 15f);
        float randomX = Random.Range(-10f, 14f);

        Instantiate(BigEnemy, new Vector3(randomX, randomY, 1), Quaternion.identity);

    }

    void SpawnSmart()
    {
        float randomY = Random.Range(12f, 15f);
        float randomX = Random.Range(-10f, 14f);


        Instantiate(SmartEnemy, new Vector3(randomX, randomY, 0), Quaternion.identity);
    }
}