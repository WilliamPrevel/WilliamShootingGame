using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour {

    public List<GameObject> pooledObjects;
    public GameObject objectToPoolA;
    public GameObject objectToPoolB;
    public GameObject objectToPoolC;
    public int amountToPool;

    public static EnemyPool SharedInstance;

    void Awake()
    {
        SharedInstance = this;
    }
    // Use this for initialization
    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPoolA);
            obj.SetActive(false);
            pooledObjects.Add(obj);
            obj = (GameObject)Instantiate(objectToPoolB);
            obj.SetActive(false);
            pooledObjects.Add(obj);
            obj = (GameObject)Instantiate(objectToPoolC);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }


    }

    public GameObject GetPooledObject(string tag)
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (pooledObjects[i] && !pooledObjects[i].activeInHierarchy && pooledObjects[i].tag == tag)
            {
                return pooledObjects[i];
            }
        }
        GameObject blah = null;
        if(tag == objectToPoolA.tag)
        {
            blah = objectToPoolA;
        }
        else if(tag == objectToPoolB.tag)
        {
            blah = objectToPoolB;

        }
        else
        {
            blah = objectToPoolC;

        }

        GameObject obj = (GameObject)Instantiate(blah);
        obj.SetActive(false);
        pooledObjects.Add(obj);
        return obj;

    }
}
