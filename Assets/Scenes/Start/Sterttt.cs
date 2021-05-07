using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sterttt : MonoBehaviour
{
    public bool onoff = false;
    float weitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(onoff == true)
        {
            weitTime += Time.deltaTime;
            if (weitTime >= 5)
            {
                SceneManager.LoadScene("1");
            }
        }
    }

    public void LightDayo2()
    {
        onoff = true;
    }
}
