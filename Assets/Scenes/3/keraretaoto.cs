using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keraretaoto : MonoBehaviour
{
    string Tname;
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

    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    Tname = other.gameObject.name;
    //    if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.LeftArrow) && Tname == "hamusuta-")
    //    {
    //        audioSource.PlayOneShot(sound1);
    //    }
    //}
}
