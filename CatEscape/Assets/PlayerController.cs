using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LButtonDown()
    {
        if (gameObject.transform.position.x > -9)
        {
            gameObject.transform.Translate(-3, 0, 0);
        }
    }

    public void RButtonDown()
    {
        if (gameObject.transform.position.x < 9)
        {
            gameObject.transform.Translate(3, 0, 0);
        }
    }
}
