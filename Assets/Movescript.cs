using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movescript : MonoBehaviour
{

    private float speed = 15.0f;
    private float jumps = 1f;
    private float jumpspeed = 12f;
    private bool isgrounded;
    private float dashes = 1f;
    private bool isDashing;
    public float dashSpeed;
    private bool isJumping = false;
    private Rigidbody rb;
    private Vector3 input;
    Vector3 m_NewForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_NewForce = new Vector3(-5.0f, 1.0f, 0.0f);
    }

    private void FixedUpdate()
    {
        rb.velocity = rb.velocity.y * Vector3.up + input * speed;
        if (isJumping)
        {
            isJumping = false;
            rb.AddForce(jumpspeed * Vector3.up, ForceMode.Impulse);
        }
        if(isDashing)
        {
            rb.AddForce(m_NewForce, ForceMode.Impulse);
        }
    }

    void Update()
    {
        input = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
        if (Input.GetKeyDown(KeyCode.LeftShift) && (dashes < 1))
        {
            isDashing = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && (jumps > 0))
        {
            isJumping = true;
        }
    }
}
