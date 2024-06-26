using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public AudioSource audioSource;
    public float horizontal;
    public float speed = 5f;
    public float jumpingPower = 5f;
    public Rigidbody2D rb;
    public bool isFacingRight;
    public bool isGrounded;
    public LayerMask groundMask;



    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        CharacterMovement();
        Flip();
    }   
    private void CharacterMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            isGrounded = false;
            audioSource.Play();
            
        }
        if (Input.GetButtonDown("Jump") && rb.velocity.x != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.8f);
            
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    private void Flip()
    { //Flip to the Left //Flip to the Right
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector2 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}