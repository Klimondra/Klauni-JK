using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public partial class VideoEndEvent : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string sceneToLoadName;

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneToLoadName);
    }

    void OnDestroy()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= OnVideoEnd;
        }
    }
}