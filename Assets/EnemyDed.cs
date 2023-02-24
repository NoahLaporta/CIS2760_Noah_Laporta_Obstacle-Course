using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDed : MonoBehaviour
{
    public float EnemyHealth;

    void Awake()
    {
        EnemyHealth = 3.0f;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Proj")
        {
            EnemyHealth -= 1.0f;
        }

        if (EnemyHealth <= 0)
        {
            Destroy(gameObject, 0.1f);
        }

        if (EnemyHealth >= 1f);
        {
            Debug.Log("Enemy Damaged");
        }
    }
}
