using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public Text Textscore;
    private int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.CompareTag("littlebox")) 
        {
            Destroy (collider.gameObject);
        }
        score = score + 1;
        Textscore.text = score.ToString ("Score :" + "0");
    }
}
