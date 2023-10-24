using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartC : MonoBehaviour
{
    public static bool onclick;//クリックされたかどうか判別変数

    public GameObject StartBotton;//スタートボタン
    public GameObject StartTimeText;//スタートタイムテキスト

    int time=3;//開始までの時間
    public Text timetext;//開始までの時間表示

    int gametime = 3;
    int times;

    // Start is called before the first frame update
    void Start()
    {
        StartTimeText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(onclick)
        {
            times += (int)Time.deltaTime;
            time = gametime - times;
            timetext.text = time.ToString();
        }
     
    }

    public void Load()
    {
        Invoke("Click", 3.0f);
     
        for(int i=0;i<=3;i++)
        {
            StartTimeText.SetActive(true);
        }
        
        StartBotton.SetActive(false);//ボタン非表示

    }

    public void Click()
    {
        onclick = true;
 
    }
}
