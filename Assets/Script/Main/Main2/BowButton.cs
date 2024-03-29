using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowButton : MonoBehaviour
{
    public GameObject itemtext;
    public GameObject Button;
    public GameObject Yazirusi;//メイン3に行く矢印
    public GameObject M_back;   //ミニゲーム用背景
    public GameObject Minigame;   //ミニゲーム用
    public GameObject M_UI;   //ミニゲーム用UI

    public static bool bowflg;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.BowFlg)
        {
            Button.SetActive(false);
            Yazirusi.SetActive(true);
        }
        Yazirusi.SetActive(false);
        itemtext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UI()
    {
        itemtext.SetActive(true);
        Button.SetActive(false);
        Yazirusi.SetActive(true);
        GameManager.BowFlg = true;
        //ミニゲーム開始
        M_back.SetActive(true);
        M_UI.SetActive(true);
        Invoke("hide",2.0f);

        bowflg = true;
        PlayerController.stop = true;
    }

    void hide()
    {
        itemtext.SetActive(false);
    }
}
