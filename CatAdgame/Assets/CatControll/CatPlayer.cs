using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    // These variables show up in the Unity Inspector
    public float moveSpeed = 14.0f;     // How fast the cat runs
    public float jumpHeight = 10.0f;   // How high the cat jumps

    // Reference to the components attached to the CatStanding_0 object
    Rigidbody2D rb;                    
    Animator anim;                     
    SpriteRenderer rend;               

    void Start()
    {
        // Link the variables to the actual components on the cat
        rb = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>();  
        rend = GetComponent<SpriteRenderer>(); 
    }

    void Update()
    {
        // 1. WALKING PART

        // Check for right movement input
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y); // Set right speed
            rend.flipX = false; // Face right
            anim.SetBool("isMoving", true); // Play walk animation
        }
        // Check for left movement input
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-moveSpeed, rb.linearVelocity.y); // Set left speed
            rend.flipX = true; // Face left (flip image)
            anim.SetBool("isMoving", true); // Play walk animation
        }
        // If no keys are pressed, stop horizontal movement
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y); 
            anim.SetBool("isMoving", false); // Stop walk animation
        }

        // 2. JUMPING PART

        // Check if Space is pressed AND the cat's vertical speed is 0 (on the ground)
        if (Input.GetKeyDown(KeyCode.Space) && rb.linearVelocity.y == 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHeight); // Apply upward force
            anim.SetBool("isJumping", true); // Trigger Catjumping1 animation
        }

        // Check if the cat has landed back on a surface
        if (rb.linearVelocity.y == 0)
        {
            anim.SetBool("isJumping", false); // Trigger Catlanding1 then back to Idle
        }
    }
}
