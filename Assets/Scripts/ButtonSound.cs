using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource source;
    [SerializeField] private AudioClip hoverOver;
    [SerializeField] private AudioClip mouseClick;
    [SerializeField] GameObject buttonAudioPlayer;
    void Start()
    {
        source = buttonAudioPlayer.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnMouseEnter()
    {
       source.PlayOneShot(hoverOver);
    }
     public void OnMouseDown()
    { 
        source.PlayOneShot(mouseClick);
    }
}
