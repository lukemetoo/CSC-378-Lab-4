using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public Animator animator; 
    private bool facingRight = true;

    public float jump;
    public bool jumping;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(speed * Move));

        // If trying to jump and not already in the air
        if (Input.GetButtonDown("Jump") && !jumping) {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        // Check to see if the sprite's direction of movement and orientation are opposite.
        // If they are, then flip the orientation of the sprite.
        if (Move > 0 && !facingRight) {
            Flip();
        } else if (Move < 0 && facingRight) {
            Flip();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Floor")) {
            jumping = false; 
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Floor")) {
            jumping = true;
        }
    }

    // This function changes orientation of sprite by changing the sign of localScale.x
    private void Flip() {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }
}
