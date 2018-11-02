using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Beam : MonoBehaviour
{
    public GameObject Beam;
	// Use this for initialization
	void Start ()
    {
		StartCoroutine(CoolDown());
	}

    IEnumerator CoolDown()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Las_Beam();
         yield return new WaitForSeconds(8f);
        }
    } 

    void Las_Beam()
    {
        Instantiate(Beam, new Vector3(3, 3, 1), Quaternion.identity);
    }
}
