using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float jumpForce;
    public bool flipped = true;
    private float moveInput;
    private Rigidbody2D rb;  
    private bool facingRight = true;
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpValue;
    void Start()
    {
        extraJumps = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moveInput));
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0) {
            Flip();
        }
        if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        //check did they press Q
        //instante(Config.get().fireballFab, );
    }
    void Update()
    {
        
        if (isGrounded == true) {
            extraJumps = extraJumpValue;
            animator.SetBool("isJumping", false);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("isJumping", true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps==0 &&  isGrounded == true) {
            rb.velocity = Vector2.up * jumpForce;
            
        }
    }
        void Flip() {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        flipped = !flipped;
    }
}
