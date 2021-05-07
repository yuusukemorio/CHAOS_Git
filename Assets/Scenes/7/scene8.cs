using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene8 : MonoBehaviour
{
    float weittime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weittime += Time.deltaTime;
        if (weittime >= 33)//45
        {
            SceneManager.LoadScene("last");//8
        }
    }
}
