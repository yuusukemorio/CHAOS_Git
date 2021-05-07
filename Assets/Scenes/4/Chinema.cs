using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chinema : MonoBehaviour
{
    float Tscale = 0;
    public Talk T;
    string Talking2 = "no";
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1.8142f, 2.488681f, 1.8142f);
    }

    // Update is called once per frame
    void Update()
    {
        Talking2 = T.Talking;
        if(Talking2 == "yes" && this.transform.localScale.y >= 1.679909f)
        {
            Tscale += Time.deltaTime / 2;
            transform.localScale = new Vector3(1.8142f, 2.488681f - Tscale, 1.8142f);
        }
    }
}
