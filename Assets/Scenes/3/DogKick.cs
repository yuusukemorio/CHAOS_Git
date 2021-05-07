using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogKick : MonoBehaviour
{
    Animator AnimaR;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        AnimaR = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.LeftArrow))
        {
            AnimaR.SetInteger("DogKick", 1);
        }
        else
        {
            AnimaR.SetInteger("DogKick", 0);
        }
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
