using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public Gamemanager gamemanager;
    private bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gamemanager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            Rigidbody2D.velocity = Vector2.up * 4;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            gamemanager.GameOverActive();
            birdIsAlive = false;
            Time.timeScale = 0;
        }
    }
}
