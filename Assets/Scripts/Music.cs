using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource source;
    [SerializeField] AudioClip song;
    void Start()
    {
        source = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            source.clip = song;
            source.loop = true;
            source.Play();
        }
    }
}
