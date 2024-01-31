using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Prime31.TransitionKit;

public class BattleScene : MonoBehaviour
{
    public string sceneName;//読み込むシーン名

    Color fadeColor = Color.black;
    float fadespeed = 1.0f;
    //public static bool movestop=false;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(se);
        Invoke("battle", 2.0f);
        PlayerController.stop = true;
    }

    void battle()
    {
        var wind = new WindTransition()
        {
            nextScene = 11,//シーンインデックスナンバーをそのまま代入
            duration = 1.0f,
            size = 0.3f
        };
        Initiate.Fade(sceneName, fadeColor, fadespeed);
        ChangeScene1.batnum = 5;
        ChangeScene1.posnum = 0;
        PlayerController.stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
