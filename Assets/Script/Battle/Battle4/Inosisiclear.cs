using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inosisiclear : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    public string sceneName;//�ǂݍ��ރV�[����
    public Text Goaltext;//�N���A���e�L�X�g
    public GameObject ClearUI;
    public GameObject Inosisi;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Goaltext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ڕW���\��
        //Goaltext.text = Isirusi.Iclearnum.ToString("0");

        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if (Isirusi.Iclearnum == 0)
        {
            StartC.onclick = false;
            audioSource.PlayOneShot(se);
            ClearUI.SetActive(true);
            Inosisi.SetActive(false);
            Invoke("Clear",2.0f);
        }
    }
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele4_1Flg = true;
    }
}
