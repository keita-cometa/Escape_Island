using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public string sceneName;//読み込むシーン名

    public int plasnum;//クリア個数
    public Text Goaltext;//クリア個数テキスト
    public GameObject ClearUI;

    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        TouchsignB.goalnum += plasnum;
        if(GameManager.Hellmode)
        {
            TouchsignB.goalnum += 10;
        }
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //目標個数表示
        Goaltext.text = TouchsignB.goalnum.ToString("0");

        if(TouchsignB.animFlg)
        {
            anim.SetBool("hit", true);
            TouchsignB.animFlg = false;
            Invoke("ani", 1.0f);
        }
        
        //goalnumが0になったらクリア関数を呼び出す
        if(TouchsignB.goalnum == 0)
        {
            TouchsignB.goalnum = 0;
            StartC.onclick = false;
            ClearUI.SetActive(true);
            Invoke("Clear", 3.0f);
        }
    }

    //クリアしたときの関数
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele1Flg = true;
    }
    void ani()
    {
        anim.SetBool("hit", false);
    }
}
