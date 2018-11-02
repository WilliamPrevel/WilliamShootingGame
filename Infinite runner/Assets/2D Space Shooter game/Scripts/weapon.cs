using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject laserPrefab;
    public BulletPool theBulletPool;

    // Update is called once per frame
    void Update ()
    {
		if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    public virtual void Shoot()
    {
        //Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        GameObject newBullet = theBulletPool.GetPooledObject();
        newBullet.transform.position = firePoint.position;
        newBullet.SetActive(true);
        
    }

}
