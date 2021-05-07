using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk_TextTransform : MonoBehaviour
{
    public Talk T;
    string Talking;
    public float ScaleTime = 0;

    public float DeleteTime = 0;

    public string TalkingEnd = null;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localScale = new Vector3(1, 1.2f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        Talking = T.Talking;
        if (Talking == "yes")
        {
            if (ScaleTime <= 0.2)
            {
                ScaleTime = ScaleTime + Time.deltaTime * 0.6f;
            }
            this.transform.localScale = new Vector3(1, 1.2f - ScaleTime, 1);

            DeleteTime = DeleteTime + Time.deltaTime;
            if (4 <= DeleteTime)
            {
                TalkingEnd = "end";
            }
        }
        else if (Talking == "no")
        {
            this.transform.localScale = new Vector3(1, 1.2f, 1);
            TalkingEnd = null;
        }
    }
}
