using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPath : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject SpawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            Instantiate(Sphere, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        }
    }
}