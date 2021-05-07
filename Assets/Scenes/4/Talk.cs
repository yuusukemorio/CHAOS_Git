using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Talk : MonoBehaviour
{
    string TrigerObj = null;
    public string Talking = "no";

    string TKE;
    public Talk_TextTransform TTTF;

    float count = 0;
    bool scene = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        TKE = TTTF.TalkingEnd;
        if (TrigerObj == "BigFace" && Input.GetKey(KeyCode.Space))
        {
            Talking = "yes";
            scene = true;
        }
        else if (TKE == "end")
        {
            Talking = "no";
            TTTF.DeleteTime = 0;
            TTTF.ScaleTime = 0;
        }


        if(scene == true)
        {
            count += Time.deltaTime;
            if (count >= 6.5)
            {
                SceneManager.LoadScene("5");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        TrigerObj = other.gameObject.name;
        Debug.Log(TrigerObj);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        TrigerObj = null;
        Debug.Log(TrigerObj);
    }
    //void OnCollisionStay2D(Collision2D collision)
    //{
    //    TrigerObj = collision.gameObject.name;

    //    if (TrigerObj == "BigFace" && Input.GetKey(KeyCode.Space))
    //    {
    //        Debug.Log("OK");
    //    }
    //}
}
