using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk_Text : MonoBehaviour
{
    RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rect.localPosition += new Vector3(10, 0, 0);
    }
}
