using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    Vector2 playerPos = new Vector2();
    Vector2 speed = new Vector2(2.0f, 0.0f);

    void Start()
    {
        
    }

    void Update()
    {
        if (this.playerPos.x < 20)
        {
            this.playerPos += this.speed;
            Debug.Log(this.playerPos);
        }
    }
}
