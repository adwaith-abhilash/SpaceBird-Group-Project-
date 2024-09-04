using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ExitEnd : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Drag your VideoPlayer here in the Inspector

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
        Application.Quit();
    }
}
