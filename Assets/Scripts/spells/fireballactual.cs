using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballactual : MonoBehaviour
{
    public GameObject[] clone;
    private Rigidbody2D rb;

    void Start()
    {
        //  Destroy(gameObject, 5f);
        // rb = GetComponent<Rigidbody2D>();
        rb = GetComponent <Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {

            faceMouse();
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = pos;
            
        }
        else
        {
            rb.velocity = Vector2.right * 5;
        }
    }

    void faceMouse()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);

        transform.up = direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            //do more damage to enemy here
        }
        else if (collision.gameObject.tag == "Player") {
            Destroy(gameObject);
            HealthBar.health -= 25f;
        }
    }
}

