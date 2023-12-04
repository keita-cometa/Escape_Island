using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Battle3Clear : MonoBehaviour
{
    // Start is called before the first frame update

    public string sceneName;//読み込むシーン名

    public int plasnum;//10に足す個数設定
    public Text Goaltext;//クリア個数テキスト

    public GameObject ClearUI;
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        GameManager.Battele3Flg = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //目標個数表示
        Goaltext.text = Touch.B3cnt.ToString("0");

        //goalnumが0になったらクリア関数を呼び出す
        if (Touch.B3cnt == 0)
        {
            audioSource.PlayOneShot(se);
            StartC.onclick = false;
            ClearUI.SetActive(true);
            Invoke("Clear", 2.0f);
        }
    }

    //クリアしたときの関数
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele3Flg = true;
    }
}
