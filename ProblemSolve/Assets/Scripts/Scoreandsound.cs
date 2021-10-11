using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreandsound : MonoBehaviour
{
    public Text Textscore;
    private int score = 0;
    public Sound sound;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.CompareTag("Brain")) 
        {
            Destroy (collider.gameObject);
            sound.PlayBite();
        }
        score = score + 1;
        Textscore.text = score.ToString ("Brains :" + "0");
    }
}
