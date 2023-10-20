using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //制限時間追加
    public GameObject timeText;//時間テキスト
    CountDown timeCnt; //CountDownスクリプトを持ってくるための変数

    // Start is called before the first frame update
    void Start()
    {
        //制限時間を追加
        //CountDownコンポーネント取得
        timeCnt = GetComponent<CountDown>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = timeCnt.CountDownTime;
        timeText.GetComponent<Text>().text = time.ToString();
    }
}
