using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dai9 : MonoBehaviour
{
    public click_me CM;
    string click_judge2;

    AudioSource audioSource;
    float audioVolTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        click_judge2 = CM.click_judge;
        if(click_judge2 == "yes")
        {
            audioVolTime -= Time.deltaTime/6;
            audioSource.volume = audioVolTime;
        }


    }
}
