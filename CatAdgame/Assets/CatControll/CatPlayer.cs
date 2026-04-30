using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    public float speed = 5f;        
    public float jumpPower = 10f;   

    Rigidbody2D myBody;             
    Animator myAnim;                
    SpriteRenderer mySprite;        

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        mySprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 1. Movement logic (same as before)
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        myBody.linearVelocity = new Vector2(horizontalInput * speed, myBody.linearVelocity.y);

        // 2. Animation and Flipping (same as before)
        if (horizontalInput != 0)
        {
            myAnim.SetBool("isMoving", true);
            if (horizontalInput < 0) {
                mySprite.flipX = true;
            } else {
                mySprite.flipX = false;
            }
        }
        else
        {
            myAnim.SetBool("isMoving", false);
        }

        // 3. New Jumping logic to prevent Double Jump
        // We check if Space is pressed AND if the cat's vertical speed is very low
        // Mathf.Abs(myBody.linearVelocity.y) < 0.01f means the cat is standing still vertically
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(myBody.linearVelocity.y) < 0.01f)
        {
            // Apply jump force only if the cat is on a surface
            myBody.linearVelocity = new Vector2(myBody.linearVelocity.x, jumpPower);
        }
    }
}