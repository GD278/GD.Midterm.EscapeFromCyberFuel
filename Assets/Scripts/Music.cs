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
        source.clip = song;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
