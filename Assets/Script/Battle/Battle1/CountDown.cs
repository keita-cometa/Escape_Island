using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    StartC startc;//StartC

    //カウントダウン変数
    public float countdown;

    //テキスト変数
    public Text timeText;

    //読み込むシーン名
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        startc = GetComponent<StartC>();
        if(GameManager.Hellmode)
        {
            countdown -= 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (StartC.onclick)
        {
            //カウントを減らす処理
            countdown -= Time.deltaTime;

            //画面に表示する
            timeText.text = countdown.ToString("f1") + "秒";

            if (countdown <= 0)
            {
                //カウントが0以下になったらLoadを呼び出してシーン移行
                Load();
            }
        }
    }

    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
