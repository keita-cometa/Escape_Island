using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //制限時間追加
    public GameObject timeText;//時間テキスト
  
    public StartC Starting;//StartCスクリプトを持ってくるための変数

    public float CountDownTime;//カウントダウン変数


    // Start is called before the first frame update
    void Start()
    { 
        //StartCコンポーネント取得
        Starting = GetComponent<StartC>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Starting.gameplay)
        {
              
            //経過時間を引いていく
            CountDownTime -= Time.deltaTime;

            //0秒以下になったら固定
            if (CountDownTime <= 0.0f)
            {
                CountDownTime = 0.0f;
            }

            //タイム更新
            timeText.GetComponent<Text>().text = CountDownTime.ToString();
        }

    }
}
