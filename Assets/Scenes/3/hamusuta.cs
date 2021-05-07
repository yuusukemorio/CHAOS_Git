 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamusuta : MonoBehaviour
{
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 force = new Vector2(100, 0);
        rb2D.AddForce(force);
    }
}
