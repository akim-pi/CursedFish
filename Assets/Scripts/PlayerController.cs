using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirectionV = Input.GetAxisRaw("Vertical");
        float moveDirectionH = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirectionH * speed, moveDirectionV * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("obstacle"))
            Destroy(gameObject);
    }
}
