using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public int nextSceneIndex = 1; // Default to scene index 1, changeable in the Inspector

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEndReached; // Subscribe to the event
    }

    public void PlayGame()
    {
        videoPlayer.Play(); // Start playing the video
    }

    private void OnVideoEndReached(VideoPlayer vp)
    {
        SceneManager.LoadSceneAsync(nextSceneIndex); // Load the scene based on the specified index
    }
}