using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hana1 : MonoBehaviour
{
    public scene8dayo S8;
    bool stop = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void hana_zyosi()
    {
        if (stop == true)
        {
            Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
            Vector2 a = new Vector2(45f, 50f);
            rb.AddForce(a);

            S8.count += 1;
            stop = false;
        }
    }
}
