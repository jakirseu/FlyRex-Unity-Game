using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyDragon : MonoBehaviour
{
    public GameManager gameManager;

    public float velocity = 1;
    public Rigidbody2D rb;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.up * velocity;

            SoundManager.PlaySound("fly");

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        SoundManager.PlaySound("fall");

        gameManager.GameOver();

    }



}
