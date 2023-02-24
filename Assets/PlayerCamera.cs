using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Vector3 cameraOffset;
    Movescript player;

    void Awake()
    {
        player = FindObjectOfType<Movescript>();

    }

    void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = cameraOffset + player.transform.position;
    }
}
