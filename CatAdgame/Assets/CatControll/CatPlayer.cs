using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float jumpForce = 12f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    void Start()
    {
        // Link the components on your Cat object
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // 1. Horizontal Movement (A/D or Arrows)
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // 2. Animation Switching
        if (moveInput != 0)
        {
            anim.SetBool("isMoving", true);
            spriteRenderer.flipX = (moveInput < 0); // Flip sprite based on direction
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

        // 3. Jump Logic (Spacebar)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}