using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTravel : MonoBehaviour
{
    private Rigidbody rb;
    public float bulletspeed = 3000.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * bulletspeed, ForceMode.Force);
    }

    void Update()
    {

    }
}
