using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartC : MonoBehaviour
{
    public static bool onclick=false;//クリックされたかどうか判別変数
    public static bool starttf=false;//開始時間表示用

    public GameObject StartBotton;//スタートボタン
    public GameObject StartTimeText;//スタートタイムテキスト
    public GameObject setumei;
    public StartSE SE;


    // Start is called before the first frame update
    void Start()
    {
        StartTimeText.SetActive(false);
        starttf = false;
        onclick = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Load()
    {
        SE.startSE();
        Invoke("Click", 3.0f);
        starttf = true;

        Debug.Log("aaa");
        StartTimeText.SetActive(true);//開始時間表示
        setumei.SetActive(false);
        StartBotton.SetActive(false);//ボタン非表示

    }

    public void Click()
    {
        onclick = true;
 
    }
}
