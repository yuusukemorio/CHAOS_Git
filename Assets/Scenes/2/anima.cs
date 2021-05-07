using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anima : MonoBehaviour
{
    Animator AnimaR;
    float WeitTime = 0;
    float WeitTime2 = 0;
    float WeitTime3 = 0;


    AudioSource audioSource;
    public AudioClip sound1;

    public int count = 0;

    bool eitooeito = true;
    // Start is called before the first frame update
    void Start()
    {
        AnimaR = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WeitTime >= 1.7f)
        {
            AnimaR.SetInteger("1_Anima", 0);
            WeitTime2 += Time.deltaTime;
            if(WeitTime2 >= 1.28f)
            {
                WeitTime = 0;
                WeitTime2 = 0;

                audioSource.PlayOneShot(sound1);
                audioSource.pitch = 1.5f;
                count++;
            }
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            WeitTime += Time.deltaTime;
            Debug.Log(WeitTime);
            AnimaR.SetInteger("1_Anima",1);
        }
        else
        {
            AnimaR.SetInteger("1_Anima", 0);
            WeitTime = 0;
            WeitTime2 = 0;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(sound1);
            audioSource.pitch = 1.5f;
            count++;
        }



        if (count >= 25)
        {
            WeitTime3 += Time.deltaTime;
            if (WeitTime3 >= 0.7)
            {
                SceneManager.LoadScene("3");
            }
        }

    }
}