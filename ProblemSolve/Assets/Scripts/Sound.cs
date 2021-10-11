using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip Bite;
    private AudioSource ball;

    void Start()
    {
        ball = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void PlayBite()
    {
        ball.PlayOneShot(Bite);
    }
}
