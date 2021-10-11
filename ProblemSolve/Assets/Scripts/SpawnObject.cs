using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject littleBox;
    public GameObject ball;

    public float range;
    private float a = 50f;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float[] horizontalPos = new float[2];
            horizontalPos[0] = Random.Range(ball.transform.position.y + range, 5);
            horizontalPos[1] = Random.Range(5 + range, ball.transform.position.y - range);

            float[] verticalPos = new float[2];
            verticalPos[0] = Random.Range(5 + range, ball.transform.position.x - range);
            verticalPos[1] = Random.Range(ball.transform.position.x + range, 5);

            float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height - a)).y);
            float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width - a, 0)).x);
     
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(littleBox, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
