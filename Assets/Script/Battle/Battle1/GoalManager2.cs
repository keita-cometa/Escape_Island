using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager2 : MonoBehaviour
{
    public string sceneName;//読み込むシーン名

    public int plasnum;//10に足す個数設定
    public Text Goaltext;//クリア個数テキスト
    public GameObject ClearUI;

    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        TouchsignB.goalnum = plasnum;
    }

    // Update is called once per frame
    void Update()
    {
        //目標個数表示
        Goaltext.text = TouchsignB.goalnum.ToString("0");

        //goalnumが0になったらクリア関数を呼び出す
        if(TouchsignB.goalnum == 0)
        {
            StartC.onclick = false;
            ClearUI.SetActive(true);
            Invoke("Clear",3.0f);
        }
    }

    //クリアしたときの関数
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.woodFlg = true;
    }
}
