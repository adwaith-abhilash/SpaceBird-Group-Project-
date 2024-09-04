using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneChanger : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Drag your VideoPlayer here in the Inspector
    public string sceneName;        // The name of the scene you want to load

    void Start()
    {
        // Ensure the VideoPlayer is assigned
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // Subscribe to the loopPointReached event
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Change the scene when the video ends
        SceneManager.LoadScene(sceneName);
    }
}
