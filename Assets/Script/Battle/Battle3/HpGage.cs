using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpGage : MonoBehaviour
{
    public Image HpGreen;   //緑のHPバー

    private bool decreaseFlag = false;  //減らすかどうかのフラグ

    private float gdecrease =0;    //緑の減らす量
    private int maxhp=0;          //現在ののMAX体力
    private int nexthp=0;         //次の体力(MAX体力-1)


    // Start is called before the first frame update
    void Start()
    {
        gdecrease = 0;
        maxhp = -5;
        nexthp = -5;
        Invoke("Initialization", 1.0f);//ゲージの初期化を遅らせる
    }

    void Initialization()
    {
        //シーンごとにMAX体力を決める
        if (SceneManager.GetActiveScene().name == "BattleScene3")
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            maxhp = Touch.B3cnt;
        }
        else
            Touch.B3cnt = 10;
        //鹿
        if (SceneManager.GetActiveScene().name == "InosisiBattle")
            maxhp = Isirusi.Iclearnum;
        else
            Isirusi.Iclearnum = 10;//イノシシ
        if (SceneManager.GetActiveScene().name == "SnakeBattle")
            maxhp = Ssirusi.Sclearnum;              //ヘビ
        else
            Ssirusi.Sclearnum = 10;

        nexthp = maxhp - 1;                     //次の体力(MAXHP-1)
        gdecrease = HpGreen.fillAmount / maxhp; //緑の減らす量(1/MAXHP)
    }
    // Update is called once per frame
    void Update()
    {
        //体力を減らす
        if (Touch.B3cnt == nexthp || Isirusi.Iclearnum == nexthp || Ssirusi.Sclearnum == nexthp)  //残りのクリック回数と次の体力が一緒になったら
        {
            Debug.Log("b");
            if (decreaseFlag == false)//一度だけ減らす
            {

                HpGreen.fillAmount -= gdecrease;    //緑の体力を減らす
                Debug.Log("a");
                maxhp = nexthp;     //次の体力だったものが今のMAX体力になる
                nexthp = maxhp - 1; //次の体力
                Debug.Log(nexthp);

                decreaseFlag = true;
            }
        }
        else
            decreaseFlag = false;
    }
}
