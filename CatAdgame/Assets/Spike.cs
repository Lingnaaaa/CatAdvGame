using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    //When the cat touch Trigger things
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the cat touth the spike
        if (other.CompareTag("Spike"))
        {
            Debug.Log("Oops!");
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        // Reloading game
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
