using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    Player player;
    private void Start()
    {
        player = Player.instance;
    }
    private void OnMouseDown()
    {
        if(ball.CompareTag("Ball"))
        {
            Destroy(ball);
            player.Addscore();
            player.AddXP(2);
        }
        else if(ball.CompareTag("non-Ball"))
        {
            Destroy(ball);
            player.Reducelife();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            player.Reducelife();
        }
        else if (collision.gameObject.CompareTag("non-Ball"))
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            player.Reducelife();
        }
        else if (gameObject.CompareTag("non-Ball"))
        {
            Destroy(gameObject);
        }
    }
}
