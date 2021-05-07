using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nois_arabesuku : MonoBehaviour
{
    AudioSource audioSource;
    float Wtime = 0;

    public int NoisSpeed = 15;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Wtime += Time.deltaTime;
        if (Wtime >= NoisSpeed)
        {
            audioSource.pitch = Random.Range(0.97f, 1.03f);
            Wtime = 0;
        }
    }
}
