using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    // These show up in the Unity editor
    public float moveSpeed = 5.0f;     // How fast the cat runs
    public float jumpHeight = 10.0f;   // How high the cat jumps

    // These are the components we need(shown on the Inspector section)
    Rigidbody2D rb;                    // To control physics
    Animator anim;                     // To control animations
    SpriteRenderer rend;               // To flip the cat's image

    void Start()
    {
        // Get the components when the game begins
        rb = GetComponent<Rigidbody2D>(); // Link the physics body
        anim = GetComponent<Animator>();  // Link the animation controller
        rend = GetComponent<SpriteRenderer>(); // Link the image renderer
    }

    void Update()
    {
        //1. WALKING PART

        // Check if the Right Arrow or D key is pressed
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y); // Move right
            rend.flipX = false; // Look to the right
            anim.SetBool("isMoving", true); // Play walk animation
        }
        // Check if the Left Arrow or A key is pressed
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-moveSpeed, rb.linearVelocity.y); // Move left
            rend.flipX = true; // Look to the left (flip the image)
            anim.SetBool("isMoving", true); // Play walk animation
        }
        // If no movement keys are pressed
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y); // Stop moving left/right
            anim.SetBool("isMoving", false); // Stop walk animation
        }

        //2. JUMPING PART

        // Simple jump: press Space and check if vertical speed is 0
        if (Input.GetKeyDown(KeyCode.Space) && rb.linearVelocity.y == 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHeight); // Give it upward speed
        }
    }
}
