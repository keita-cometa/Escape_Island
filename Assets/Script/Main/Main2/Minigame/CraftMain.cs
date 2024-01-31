using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMain : MonoBehaviour
{
    static public int MCrear = 10;
    static public bool MCrearFlag = false;
    public GameObject craftCanvas;//クラフトキャンバス
    public GameObject MinigameImg;//クラフト画面
    public GameObject clear;//クリア画像

    public GameObject gettext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MCrear==0)
        {
            MCrearFlag = true;
            clear.SetActive(true);
            Invoke("quit", 2.0f);
        }
    }

    void quit()
    {
        craftCanvas.SetActive(false);
        MinigameImg.SetActive(false);
        clear.SetActive(false);
        gettext.SetActive(true);
        PlayerController.stop = false;//クラフト中はプレイヤーを止める
    }
}
