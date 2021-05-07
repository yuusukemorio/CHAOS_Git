using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_esa : MonoBehaviour
{
    public esa_seimeitainohou esa;
    int esa2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        esa2 = esa.count;
        if(esa2 >= 10)
        {
            transform.position = new Vector2(transform.position.x - Time.deltaTime, transform.position.y + Time.deltaTime);
        }
    }
}
