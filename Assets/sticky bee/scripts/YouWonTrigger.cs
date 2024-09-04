using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWonTrigger : MonoBehaviour
{
    public string youWonSceneName = "YouWonScene"; // Name of the scene to load when the player wins

    // Detect collision with the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Load the "You Won" scene
            SceneManager.LoadScene(youWonSceneName);
        }
    }
}
