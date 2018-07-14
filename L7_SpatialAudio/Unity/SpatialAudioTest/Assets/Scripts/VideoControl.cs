using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControl : MonoBehaviour {

    private UnityEngine.Video.VideoPlayer videoPlayer;

    [SerializeField]
    private AudioSource audioSource;

    void Start () {
        videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer> ();
		audioSource = gameObject.AddComponent<AudioSource>();


        if (videoPlayer.clip != null)
        {
			videoPlayer.audioOutputMode = UnityEngine.Video.VideoAudioOutputMode.AudioSource;
			videoPlayer.EnableAudioTrack(0, true);
//			audioSource.volume = 1.0f;
            videoPlayer.SetTargetAudioSource(0, audioSource);
			videoPlayer.controlledAudioTrackCount = 1;
			videoPlayer.Prepare ();
        }
    }

    //Check if input keys have been pressed and call methods accordingly.
    void Update(){
        //Play or pause the video.

    }

	public void toggleVideoState() {
	  if (videoPlayer.isPlaying) {
        videoPlayer.Pause ();
      } else {
        videoPlayer.Play();
      }
	}

	public void restartVideoState() {
		videoPlayer.Stop ();
	}
		
}
