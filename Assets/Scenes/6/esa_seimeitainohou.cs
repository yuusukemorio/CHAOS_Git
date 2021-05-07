using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esa_seimeitainohou : MonoBehaviour
{
    public int count = 0;
    public GameObject GOBJ;
    public GameObject GOBJ2;

    float weittime = 0;
    // Start is called before the first frame update
    void Start()
    {
        GOBJ.SetActive(false);
        GOBJ2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(count >= 10)//28
        {
            GOBJ.SetActive(true);
            weittime += Time.deltaTime;
            if (weittime >= 25)
            {
                GOBJ2.SetActive(true);
                if (weittime >= 46)
                {
                    SceneManager.LoadScene("8");
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "esa_P")
        {
            count += 1;
            this.transform.localScale = new Vector3(transform.localScale.x + 0.002f, transform.localScale.y + 0.002f, transform.localScale.z + 0.002f);
        }
        if (collision.gameObject.name == "esa_P2")
        {
            count += 1;
            this.transform.localScale = new Vector3(transform.localScale.x + 0.01f, transform.localScale.y + 0.01f, transform.localScale.z + 0.01f);
        }
    }
}
