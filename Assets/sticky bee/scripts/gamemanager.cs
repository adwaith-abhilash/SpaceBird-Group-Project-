using UnityEngine;

public class gamemanager : MonoBehaviour
{
    private move player; // Reference to the player
    public GameObject GameOve; // Reference to the Game Over screen

    void Start()
    {
        GameOve.SetActive(false); // Hide Game Over screen at start

        // Automatically find the player object with the 'move' script attached
        player = FindObjectOfType<move>();

        if (player == null)
        {
            Debug.LogError("Move component not found on any GameObject in the scene!");
        }
    }

    public void Play()
    {
        GameOve.SetActive(false); // Hide Game Over screen
        Time.timeScale = 1f; // Resume game

        if (player != null)
        {
            player.enabled = true; // Enable player movement
        }
    }

    public void GameOver()
    {
        Debug.Log("game over");
        GameOve.SetActive(true); // Show Game Over screen
        Pause(); // Pause the game
    }

    public void Pause()
    {
        Time.timeScale = 0f; // Pause game time

        if (player != null)
        {
            player.enabled = false; // Disable player movement
        }
    }
}
