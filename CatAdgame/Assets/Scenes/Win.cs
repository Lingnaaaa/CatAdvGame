using UnityEngine;
using TMPro; // TextMeshPro (I used it in the UI Page so I need it in this line)

public class Win : MonoBehaviour
{
    public GameObject winPanel;

    // When this player touch item has Box Collider 2D and cat or item is trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //If the object's tag is Fish
        if (other.CompareTag("Fish"))
        {
            Debug.Log("Win!"); //Print Win! at console
            
            // Appear the "You Win" UI page
            winPanel.SetActive(true);
            
            //disappear the fish
            Destroy(other.gameObject);
            
        }
    }
}
