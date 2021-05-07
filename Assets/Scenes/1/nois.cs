using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nois : MonoBehaviour
{
    AudioSource audioSource;
    int Wtime = 0;

    public int NoisSpeed = 15;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Wtime += (int)Time.deltaTime;
        if (Wtime % NoisSpeed == 0)
        {
            audioSource.pitch = Random.Range(0.1f, 2);
            audioSource.panStereo = Random.Range(-0.5f, 0.5f);
        }
    }
}
