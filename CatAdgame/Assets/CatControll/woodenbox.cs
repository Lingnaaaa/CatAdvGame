using UnityEngine;

public class woodenBox : MonoBehaviour
{
    // this code runs when the box is hit
    void OnCollisionEnter2D(Collision2D other)
    {
        // If is the player (Cat) crash the box
        if (other.gameObject.tag == "Player")
        {
            // If player's position is under the box
            if (other.transform.position.y < transform.position.y)
            {
                Debug.Log("<size=30>BOOM!</size>");
                
                // destroy the box
                Destroy(gameObject);
            }
        }
    }
}
