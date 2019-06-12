using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Racket : MonoBehaviour
{
    [Tooltip("This area determine velocity of both racket and racketAI")]
    public float moveSpeed;
    int score;
    [Tooltip("This area determine score of  both racket and racketAI")]
    public Text racketScore;
    protected Rigidbody2D rb2;

    protected  void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        if (observerDifficultAI.difficultState.Equals("EASY"))
           RacketAI.refenceVal = 3f;
        else if (observerDifficultAI.difficultState.Equals("MİD"))
            RacketAI.refenceVal = 2f;
        else
            RacketAI.refenceVal = 1f;
    }


    protected virtual void FixedUpdate()
    {
        float moveAxis = Input.acceleration.y;

        if (moveAxis < -1)
            moveAxis = -1;
        if (moveAxis > -0.8f)
            moveAxis = -0.8f;

        var result = Mathf.Lerp(-1, 1, Mathf.InverseLerp(-1, -0.8f, moveAxis));
        rb2.velocity = new Vector2(0, result) * moveSpeed;
    }


    public void makeScore()
    {
        score++;
        racketScore.text = score.ToString();
    }
}
