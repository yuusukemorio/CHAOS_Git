using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float WalkSpeed = 5.0f;
    public float JampSpeed = 5.0f;
    float xSpeed;
    float ySpeed;

    public GroundJudg ground;
    bool isGround = false;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = ground.IsGround();
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xSpeed = -WalkSpeed;
            //rb.velocity = new Vector3(-WalkSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            xSpeed = WalkSpeed;
            //rb.velocity = new Vector3(WalkSpeed, 0);
        }
        else
        {
            xSpeed = 0;
        }

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    //rb.velocity = new Vector3(0, JampSpeed);
        //}
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }
}
