using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0f,0f);
        if(transform.position.y >= 10.17f)
        {
            transform.position = new Vector3(0, -9.94f, 0);
        }
    }
}
