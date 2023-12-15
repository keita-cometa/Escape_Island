using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpGage : MonoBehaviour
{
    public WolfManager wolfManager;

    public Image HpGreen;   //緑のHPバー

    private bool decreaseFlag = false;  //減らすかどうかのフラグ

    private float gdecrease;    //緑の減らす量
    private int maxhp;          //現在ののMAX体力
    private int nexthp;         //次の体力(MAX体力-1)


    // Start is called before the first frame update
    void Start()
    {
        //シーンごとにMAX体力を決める
        if (SceneManager.GetActiveScene().name == "BattleScene3")
            maxhp = Touch.B3cnt;                    //鹿
        else if (SceneManager.GetActiveScene().name == "InosisiBattle")
            maxhp = Isirusi.Iclearnum;              //イノシシ
        else if (SceneManager.GetActiveScene().name == "SnakeBattle")
            maxhp = Ssirusi.Sclearnum;              //ヘビ
        
        nexthp = maxhp - 1;                     //次の体力(MAXHP-1)
        gdecrease = HpGreen.fillAmount / maxhp; //緑の減らす量(1/MAXHP)
    }

    // Update is called once per frame
    void Update()
    {
        //体力を減らす
        if (Touch.B3cnt == nexthp || Isirusi.Iclearnum == nexthp || Ssirusi.Sclearnum == nexthp)  //残りのクリック回数と次の体力が一緒になったら
        {
            if (decreaseFlag == false)//一度だけ減らす
            {
                HpGreen.fillAmount -= gdecrease;    //緑の体力を減らす
                Debug.Log("g");

                maxhp = nexthp;     //次の体力だったものが今のMAX体力になる
                nexthp = maxhp - 1; //次の体力


                decreaseFlag = true;
            }
        }
        else
            decreaseFlag = false;
    }
}
