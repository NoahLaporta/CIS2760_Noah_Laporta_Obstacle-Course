using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullDS : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject, 0.01f);
        }
    }
}
