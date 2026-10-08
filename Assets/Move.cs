using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float jumpForce = 5f;
    public float speed = 1f;
    Rigidbody2D rb;
    private bool flipRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

        if (movement > 0 && !flipRight)
        {
            Flip();
        }
        else if (movement < 0 && flipRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        flipRight = !flipRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
