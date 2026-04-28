using UnityEngine;
using TMPro; // TextMeshPro (I used it in the UI so I need it in this line)

public class winwinwin : MonoBehaviour
{
    public GameObject winPanel;

    // When this player touch something is trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //If the object's tag is Fish
        if (other.CompareTag("Fish"))
        {
            Debug.Log("Win!");
            
            // Appear the "You Win" page
            winPanel.SetActive(true);
            
            // 2. disappear the fish
            Destroy(other.gameObject);
            
        }
    }
}
