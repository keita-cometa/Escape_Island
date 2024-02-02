using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Prime31.TransitionKit;

public class Wolf : MonoBehaviour
{
    public string sceneName;//読み込むシーン名

    Color fadeColor = Color.black;
    float fadespeed = 1.0f;
    private AudioSource audioSource;
    public GameObject Wolfs;

    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Wolfs.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Battele5Flg==true)
        {
            Wolfs.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController.stop = true;
            audioSource.PlayOneShot(se);
            Invoke("Load", 2.0f);
       
    }

    void Load()
    {
        var slices = new TriangleSlicesTransition()
        {
            nextScene = 12,//シーンインデックスナンバーをそのまま代入
            divisions = Random.Range(2, 10)
        };
        Initiate.Fade(sceneName, fadeColor, fadespeed);
        ChangeScene1.batnum = 6;
        ChangeScene1.posnum = 0;
        //PlayerController.stop = false;
    }

}
