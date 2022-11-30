using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Networking;

public class OnlineVideoLoader : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string videoUrl = "yourvideourl";





    // Start is called before the first frame update
    public void loadVideo()
    {

        StartCoroutine(GetAssetBundle());

        IEnumerator GetAssetBundle()
        {
            UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(videoUrl);
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {

                videoPlayer.url = videoUrl;
                videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
                videoPlayer.EnableAudioTrack(0, true);
                videoPlayer.Prepare();
            }
        }
    }

}