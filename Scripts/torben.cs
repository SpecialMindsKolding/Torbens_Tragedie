using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torben : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;
    public SpriteRenderer SR;
    public Sprite h�jre;
    public Sprite venstre;
    public Sprite mellem;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }

    void FixedUpdate()
    {
        if (horizontal > 0)
        {
            Debug.Log("h�jre");
            SR.sprite = h�jre;
        }
        else if (horizontal < 0)
        {
            Debug.Log("venstre");
            SR.sprite = venstre;
        }
        if (vertical > 0)
        {
            Debug.Log("op");
            SR.sprite = h�jre;
        }
        else if (vertical < 0)
        {
            Debug.Log("ned");
            SR.sprite = venstre;
        }
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;

            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
