using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitti : MonoBehaviour
{
    public Sterttt S;
    bool c;
    bool b = true;

    AudioSource audioSource;
    public AudioClip sound1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        c = S.onoff;
        if (c == true && b == true)
        {
            audioSource.PlayOneShot(sound1);
            b = false;
        }
    }
}
