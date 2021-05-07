using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class konnnitiwa : MonoBehaviour
{
    public GameObject hamusuta;
    float WeitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = (GameObject)Resources.Load("hamusuta-");
    }

    // Update is called once per frame
    void Update()
    {
        WeitTime += Time.deltaTime;
        if (WeitTime >= Random.Range(3.5f, 7))
        {
            WeitTime = 0;
            Instantiate(hamusuta, new Vector3(-11.13f, 4.01f, 0), Quaternion.identity);
        }
    }
}
