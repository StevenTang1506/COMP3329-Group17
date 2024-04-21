using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;

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
        SceneManager.LoadSceneAsync(1);
    }
}