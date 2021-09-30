using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = 0.094f;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
