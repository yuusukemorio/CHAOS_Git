using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hana : MonoBehaviour
{
    public click_me CM;
    string click_judge2;

    public GameObject GOBJ;
    public GameObject GOBJ2;

    float weittime = 0;
    float scenetime = 0;
    // Start is called before the first frame update
    void Start()
    {
        GOBJ.SetActive(false);
        GOBJ2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        click_judge2 = CM.click_judge;
        if (click_judge2 == "yes")
        {
            weittime += Time.deltaTime;
            if (weittime >= 22)
            {
                GOBJ.SetActive(true);
                GOBJ2.SetActive(true);
                scenetime += Time.deltaTime;
                if (weittime >= 50)
                {
                    
                    SceneManager.LoadScene("6");
                }
            }
        }
    }
}
