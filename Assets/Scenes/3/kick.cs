using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kick : MonoBehaviour
{
    string Tname;
    AudioSource audioSource;
    public AudioClip sound1;

    int count = 0;

    float WeitTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x >= 3f)
            {
                transform.Translate(-2f, 0, 0);
            }
        }
        else
        {
            if (transform.position.x <= 5f)
            {
                transform.Translate(2f, 0, 0);
            }
        }


        if(count >= 5)
        {
            WeitTime += Time.deltaTime;
            if (WeitTime >= 1)
            {
                SceneManager.LoadScene("4");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Tname = collision.gameObject.name;
        audioSource.PlayOneShot(sound1);
        count = count + 1;
    }
}
