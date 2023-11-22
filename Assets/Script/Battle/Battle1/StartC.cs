using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartC : MonoBehaviour
{
    public static bool onclick;//クリックされたかどうか判別変数
    public static bool starttf;

    public GameObject StartBotton;//スタートボタン
    public GameObject StartTimeText;//スタートタイムテキスト


    // Start is called before the first frame update
    void Start()
    {
        StartTimeText.SetActive(false);
        starttf = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Load()
    {
        Invoke("Click", 3.0f);
        starttf = true;

        Debug.Log("aaa");
        StartTimeText.SetActive(true);//開始時間表示
              
        StartBotton.SetActive(false);//ボタン非表示

    }

    public void Click()
    {
        onclick = true;
 
    }
}
