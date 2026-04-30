using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    //When the cat touch item which have Box Collider 2D and cat or item is Trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the cat touth the item's Tag is Spike.
        if (other.CompareTag("Spike"))
        {
            Debug.Log("Oops!");
            //runs RestartLevel code
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        // Reloading game. GetActiveScene.name means get know the currently scene name.
        string currentSceneName = SceneManager.GetActiveScene().name;
        //LoadScene means reload the scene that we currently in. 
        SceneManager.LoadScene(currentSceneName);
    }
}
