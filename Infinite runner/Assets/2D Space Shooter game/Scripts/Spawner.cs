using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SmallEnemy;
    public GameObject BigEnemy;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject SmartEnemy;
=======
    public EnemyPoolA theEnemyPoolA;
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
    public EnemyPoolA theEnemyPoolA;
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
    public EnemyPoolA theEnemyPoolA;
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
    public EnemyPoolA theEnemyPoolA;
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
>>>>>>> parent of d108919... made a smart AI

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
        
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    }

    void SpawnBig()
    {
        float randomY = Random.Range(12f, 15f);
        float randomX = Random.Range(-10f, 14f);

        //Instantiate(BigEnemy, new Vector3(randomX, randomY, 0), Quaternion.identity);
        GameObject newEnemyA = theEnemyPoolA.GetPooledObject();
        newEnemyA.transform.position = new Vector3(randomX, randomY, 1);
        newEnemyA.SetActive(true);
=======
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
        Instantiate(SmallEnemy, new Vector3(randomX, randomY, 1), Quaternion.identity);
>>>>>>> parent of d108919... made a smart AI
    }

    void spawnBig()
    {
        float randomY = Random.Range(12f, 15f);
        float randomX = Random.Range(-10f, 14f);

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        Instantiate(SmartEnemy, new Vector3(randomX, randomY, 0), Quaternion.identity);
=======
=======
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
        //Instantiate(BigEnemy, new Vector3(randomX, randomY, 0), Quaternion.identity);
        GameObject newEnemyA = theEnemyPoolA.GetPooledObject();
        newEnemyA.transform.position = new Vector3(randomX, randomY, 1);
        newEnemyA.SetActive(true);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
>>>>>>> 5a949333d1802c4269f84596d7dc7fffd610d2ca
=======
        Instantiate(BigEnemy, new Vector3(randomX, randomY, 0), Quaternion.identity);
>>>>>>> parent of d108919... made a smart AI
    }
}