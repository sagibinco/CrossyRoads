using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    public Sprite RightBoy;
    public Sprite LeftBoy;
    public Sprite Boy;
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(moveHorizontal*speed, moveVertical*speed);
        
        if (end.x < 7.8 && end.y < 7.22 && end.x > -7.15 && end.y > -7.09)
        {
            rb2d.MovePosition(end);
        }
        if (moveHorizontal > 0)
        {
            GetComponent<SpriteRenderer>().sprite = LeftBoy;
        }
        if (moveHorizontal < 0)
        {
            GetComponent<SpriteRenderer>().sprite = RightBoy;
        }
        if (moveVertical > 0 && moveHorizontal == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Boy;
        }
    }
}
