using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene8dayo : MonoBehaviour
{
    public int count = 0;
    float weitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count >= 2)
        {
            weitTime += Time.deltaTime;
            if(weitTime >= 8)
            {
                SceneManager.LoadScene("7");
            }

        }
    }
}
