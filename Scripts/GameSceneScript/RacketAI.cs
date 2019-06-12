using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacketAI : Racket
{
    public Transform ball;
    public static float refenceVal;    

    protected override  void FixedUpdate()
    {
        float topRaketFarkY = Mathf.Abs(ball.position.y - transform.position.y);
       
        if (topRaketFarkY > refenceVal)
        {
            if (ball.position.y > transform.position.y)
            {
                rb2.velocity = Vector2.up * moveSpeed;
            }

            else
                rb2.velocity = Vector2.down * moveSpeed;
        }
       
    }
}
