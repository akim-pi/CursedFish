using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    private float length;
    private float scrollSpeed = -2f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        length = collider.size.x;
        collider.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);

        resetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -length)
        {
            Vector2 resetPosition = new Vector2(length * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            
            resetObstacle();
        }
    }

    void resetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(0, Random.Range(-3,3), 0);
    }
}
