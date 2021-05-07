using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dai9_me : MonoBehaviour
{
    public click_me CM;
    string click_judge2;

    AudioSource audioSource;
    public AudioClip sound1;
    float audioVolTime = 1;

    bool stop = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            click_judge2 = CM.click_judge;
        }

        if (click_judge2 == "yes")
        {
            audioVolTime += Time.deltaTime;
            if(audioVolTime >= 7)
            {
                audioSource.PlayOneShot(sound1);
                stop = true;
                click_judge2 = "null";
                Debug.Log("YES");
            }
        }


    }
}