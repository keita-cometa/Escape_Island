using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class snakeclear : MonoBehaviour
{
    public string sceneName;
    public Text Goaltext;//�N���A���e�L�X�g

    public GameObject ClearUI;
    public GameObject Snake;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Goaltext = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //�ڕW���\��
        //Goaltext.text = Ssirusi.Sclearnum.ToString("0");

        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if (Ssirusi.Sclearnum == 0)
        {
            StartC.onclick = false;
            ClearUI.SetActive(true);
            Snake.SetActive(false);
            Invoke("Clear",2.0f);
        }
    }
     void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele4_2Flg = true;
    }

}
