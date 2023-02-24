using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private float chasedist = 20f;
    private float enemyPDC;
    public float speed = 0.50f;

    void Awake()
    {
        var heading = GameObject.Find("Enemy").transform.position - GameObject.Find("Player").transform.position;
        var direction = heading / enemyPDC;
        speed = 10f;
    }

    void Update()
    {
        Vector3 targetDirection = GameObject.Find("Enemy").transform.position - GameObject.Find("Player").transform.position;
        float singlestep = speed * Time.deltaTime;
        var step = speed * Time.deltaTime;
        Vector3 playerDirection = Vector3.RotateTowards(transform.forward, targetDirection, singlestep, 0.0f);
        enemyPDC = (GameObject.Find("Enemy").transform.position - GameObject.Find("Player").transform.position).magnitude;
        if (chasedist > enemyPDC)
        {
            transform.rotation = Quaternion.LookRotation(playerDirection);
            transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Player").transform.position, step);
        }
    }
}
