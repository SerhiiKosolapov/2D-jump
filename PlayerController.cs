using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class PlayerController : MonoBehaviour
{
    public float speed =5f, jumpForce = 5f, checkRadius = 0.5f;
    public bool isGrounded;
    private Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask whatIsGround;

    private bool facingright = true;

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        float movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movement * speed, rb.velocity.y);

        if ((movement < 0 || movement > 0) && isGrounded)
        {
            animator.SetBool("walking", true);
            animator.SetBool("jumping", false);
            animator.SetBool("idle", false);
            animator.SetBool("prepareToJump", false);
        }
        else if (movement == 0 && isGrounded)
        {
            animator.SetBool("idle", true);
            animator.SetBool("walking", false);
            animator.SetBool("jumping", false);
            animator.SetBool("prepareToJump", false);
        }
        else if (!isGrounded && movement != 0)
        {
            animator.SetBool("jumping", true);
            animator.SetBool("walking", false);
            animator.SetBool("idle", false);
            animator.SetBool("prepareToJump", false);
        }

        if (movement == 0 && Input.GetMouseButton(0) && isGrounded)
        {
            animator.SetBool("jumping", false);
            animator.SetBool("walking", false);
            animator.SetBool("idle", false);
            animator.SetBool("prepareToJump", true);
        }
        else
            animator.SetBool("prepareToJump", false);

        if (!facingright && movement > 0)
        {
            Flip();
        }
        else if (facingright && movement <  0)
        {
            Flip();
        }

        if (Input.GetMouseButtonUp(0) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            //rb.velocity = Vector2.up * jumpForce;
            animator.SetBool("jumping", false);
        }
    }
    void Flip()
    {
        facingright = !facingright;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
