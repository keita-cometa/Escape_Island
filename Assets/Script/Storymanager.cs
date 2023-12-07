using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Storymanager : MonoBehaviour
{
    public string sceneName;//ì«Ç›çûÇﬁÉVÅ[Éìñº

    //private AudioSource audioSource;
    //[SerializeField] private AudioClip se;

    Color fadeColor = Color.black;
    float fadespeed = 1.0f;

    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey || Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2))
        {
            //audioSource.PlayOneShot(se);
            Initiate.Fade(sceneName, fadeColor, fadespeed);
        }
        if((ulong)videoPlayer.frame == videoPlayer.frameCount)
        {
            Initiate.Fade(sceneName, fadeColor, fadespeed);
        }
    }
}
