using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    
    public void PlayVideo()
    {
        videoPlayer.Play();
    }

    public void StopVideo()
    {   
        videoPlayer.Stop();
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }
}
