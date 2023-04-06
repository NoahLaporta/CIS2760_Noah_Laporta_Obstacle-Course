using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashComm : MonoBehaviour
{
    public float dashes;
    public float dashSpeed = 300.0f;
    public float dashLength;
    private Rigidbody rb;

    void Awake()
    {
        dashes = 2.0f;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.velocity = new Vector3(0, 0, dashSpeed);
        }
    }
}
