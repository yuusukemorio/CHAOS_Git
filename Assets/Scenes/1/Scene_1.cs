using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_1 : MonoBehaviour
{
    string Tname;
    float WeitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tname == "SC")
        {
            WeitTime += Time.deltaTime;
            if (WeitTime >= 1)
            {
                SceneManager.LoadScene("2");
            }
        }
        else if (Tname == "FC")
        {
            WeitTime += Time.deltaTime;
            if (WeitTime >= 1)
            {
                Quit();
            }
        }
    }

    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Tname = other.gameObject.name;
        Debug.Log(other);
    }
}
