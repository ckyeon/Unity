using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    GameObject director;

    // Start is called before the first frame update
    void Start()    //게임이 시작할 때 실행
    {
        this.player = GameObject.Find("player");
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()   //프레임 마다 실행
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f) {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.8f;

        if (d < r1 + r2)
        {
            this.director.GetComponent<GameDirector>().DecreaseHP();

            Destroy(gameObject);
        }
    }
}
