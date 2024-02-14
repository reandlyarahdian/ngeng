using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audio;
    public bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        audio.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onece();
        }
    }
    void onece()
    {
        if(once == false)
        {
            audio.Play();
            once = true;
        }
        else
        {
            audio.Pause();
            once = false;
        }
    }
}
