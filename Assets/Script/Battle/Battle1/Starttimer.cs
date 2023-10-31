using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starttimer : MonoBehaviour
{
    public GameObject StartTimeText;//スタートタイムテキスト

    public Text Timetext;//開始時間テキスト
    float startlimit=3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Timetext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!StartC.starttf)
        {
            return;
        }
        startlimit -= Time.deltaTime;
        Timetext.text = startlimit.ToString("0");


        if(startlimit<=0)
        {
            Timetext.text = "スタート！";
            StartTimeText.SetActive(false);
            
        }
    }
}
