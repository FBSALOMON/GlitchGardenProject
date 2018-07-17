using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerTest : MonoBehaviour
{

    private void Start()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        AudioSource audioSource = GetComponent<AudioSource>();

        videoPlayer.SetTargetAudioSource(0, audioSource);
        videoPlayer.EnableAudioTrack(0, true);
    }
    
}