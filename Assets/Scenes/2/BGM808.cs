using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM808 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sound1;

    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(sound1);
            audioSource.pitch = 1.5f;
            count++;
        }
        //else if (Input.GetMouseButtonDown(0))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 1f;
        //    count++;
        //}
        //else if (Input.GetMouseButtonDown(1))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 1.8f;
        //    count++;
        //}
        //else if (Input.GetMouseButtonDown(2))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 2f;
        //    count++;
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 0.75f;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 0.85f;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 0.95f;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha4))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 1;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha5))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 1.5f;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha6))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 2;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha7))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 2.5f;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha8))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 3;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha9))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 4.5f;
        //    count++;
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha0))
        //{
        //    audioSource.PlayOneShot(sound1);
        //    audioSource.pitch = 5;
        //    count++;
        //}

        if (count >= 15)
        {
            SceneManager.LoadScene("3");
        }
    }
}