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
            Spawn(SmallEnemy);
            Spawn(BigEnemy);
            Spawn(SmartEnemy);

            yield return new WaitForSeconds(4f);
        }
    }

    void Spawn(GameObject enemy)
    {
        float randomY = Random.Range(6f, 11f);
        float randomX = Random.Range(-8.4f, 9.4f);

        Instantiate(enemy, new Vector3(randomX, randomY, 0), Quaternion.identity);
    }
}
