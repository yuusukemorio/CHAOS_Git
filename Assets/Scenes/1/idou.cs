using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour {

    private const float G = 9.9f;
    Rigidbody2D R2D;

    // Use this for initialization
    void Start()
    {
        R2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = new Vector3(0, 0, 0);
        velocity.x += Input.GetAxis("Horizontal");
        velocity.y += Input.GetAxis("Vertical");
        if (Input.GetButton("Fire1"))
        {
            velocity.y += 1.0f;
        }
        if (Input.GetButton("Fire2"))
        {
            velocity.y += -1.0f;
        }

        R2D.velocity = velocity * 50 * Time.deltaTime + new Vector3(0, G + Random.Range(0.0f, 10.0f), 0) * Time.deltaTime;
        var originalRotation = R2D.rotation;
        var zEular = 0.0f;
        if (R2D.velocity.x > 0)
        {
            zEular = -5.0f;
        }
        else if (R2D.velocity.x < 0)
        {
            zEular = 5.0f;
        }

        var xEular = 0.0f;
        if (R2D.velocity.y > 0)
        {
            xEular = 5.0f;
        }
        else if (R2D.velocity.y < 0)
        {
            xEular = -5.0f;
        }
        var eular = new Vector3(xEular, 0, zEular);
    }
}