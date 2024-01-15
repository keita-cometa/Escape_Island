using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public string sceneName;//ì«Ç›çûÇﬁÉVÅ[Éìñº

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    Color fadeColor = Color.black;
    float fadespeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //GameManager.ClearFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey||Input.GetMouseButton(0)|| Input.GetMouseButton(1)|| Input.GetMouseButton(2))
        {
            audioSource.PlayOneShot(se);
            Initiate.Fade(sceneName, fadeColor, fadespeed);
        }
    }
}
