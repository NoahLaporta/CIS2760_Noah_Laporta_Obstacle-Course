using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillComm : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            Destroy(gameObject, 0.1f);
        }
    }

    private void Update()
    {

    }
}
