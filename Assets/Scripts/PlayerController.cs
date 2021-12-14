using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5;
    public float score;
    public float highscore;

    //[SerializedField]
    bool isAlive = true;

    public Text ScoreTxt;
    public Text Mati;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        highscore = PlayerPrefs.GetFloat("Highscore");
    }

    private void FixedUpdate() 
    {
        if(Time.deltaTime % 5 == 0)
            speed += 1;
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirectionV = Input.GetAxisRaw("Vertical");
        //float moveDirectionH = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(0, moveDirectionV * speed);
        if(score > highscore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }
        
        if (isAlive)
        {
            score += Time.deltaTime * 4;
            ScoreTxt.text = "SCORE : " + ((int)score).ToString();
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
            isAlive = false;
        }
            
    }
}
