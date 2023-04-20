using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadController : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;
    public float nowPosi;
    public float xpos1;
    public float xpos2;

    void Start()
    {
        nowPosi = this.transform.position.y;
    }

    void Update()
    {
        pos = transform.position;

        // （ポイント）マイナスをかけることで逆方向に移動する。
        transform.Translate(transform.right * Time.deltaTime * 1 * num);
        transform.position = new Vector2(transform.position.x, nowPosi + Mathf.PingPong(Time.time * 2, 2f));
        
        if (pos.x < xpos1)
        {
            num = 1;
        }

       if (pos.x > xpos2)
        {
            num = -1;
        }

        if (pos.x < -10)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (pos.x > 15)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
