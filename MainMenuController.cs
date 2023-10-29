using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");

        var videoPlayer = camera.AddComponent<VideoPlayer>();

        videoPlayer.playOnAwake = true;

        videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;

        videoPlayer.targetCameraAlpha = 0.5F;

        videoPlayer.frame = 100;

        videoPlayer.isLooping = true;

      
        videoPlayer.loopPointReached += EndReached;

        
        videoPlayer.Play();
    }

    void EndReached(VideoPlayer vp)
    {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
    }
}