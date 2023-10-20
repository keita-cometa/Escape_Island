using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float CountDownTime;//カウントダウン変数
    public Text TextCountDown;//表示テキスト変数

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 10.0f;//カウントダウンの値を設定
    }

    // Update is called once per frame
    void Update()
    {
        //カウントダウンを整形して表示
        TextCountDown.text = string.Format("制限時間: {0:00.00}", CountDownTime);
        //経過時間を引いていく
        CountDownTime -= Time.deltaTime;

        //0秒以下になったら固定
        if(CountDownTime<=0.0f)
        {
            CountDownTime = 0.0f;
        }
    }
}
