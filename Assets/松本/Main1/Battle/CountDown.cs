using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float CountDownTime;//カウントダウン変数
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //経過時間を引いていく
        CountDownTime -= Time.deltaTime;

        //0秒以下になったら固定
        if(CountDownTime<=0.0f)
        {
            CountDownTime = 0.0f;
        }
    }
}
