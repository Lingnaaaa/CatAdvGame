using UnityEngine;

public class WoodenBox : MonoBehaviour
{
    // this code runs when the box is hit by a item have Box Collider 2D
    void OnCollisionEnter2D(Collision2D other)
    {
        // If is the tag is player (Cat) crash the box
        if (other.gameObject.tag == "Player")
        {
            // If player's position is under the box
            if (other.transform.position.y < transform.position.y)
            //other.trans means player, transform is the box
            {
                Debug.Log("<size=30>BOOM!</size>"); 
                
                // destroy the box
                Destroy(gameObject);
            }
        }
    }
}
