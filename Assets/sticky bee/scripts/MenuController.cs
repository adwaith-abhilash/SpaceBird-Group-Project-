using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string playSceneName = "GameScene"; // Name of the scene to load when Play is clicked

    // Method called when Play button is clicked
    public void PlayGame()
    {
        SceneManager.LoadScene(playSceneName);
    }

    // Method called when Exit button is clicked
    public void ExitGame()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
