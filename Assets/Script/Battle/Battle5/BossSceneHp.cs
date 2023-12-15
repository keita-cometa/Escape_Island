using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossSceneHp : MonoBehaviour
{
    public WolfManager wolfManager;

    public Image HpGreen;   //緑のHPバー
    private bool decreaseFlag = false;  //減らすかどうかのフラグ
    private float gdecrease;    //緑の減らす量

    //プレイヤー
    private int maxhp;          //現在ののMAX体力
    private int nexthp;         //次の体力(MAX体力-1)

   
    // Start is called before the first frame update
    void Start()
    {
        maxhp = wolfManager.PHP;
        nexthp = maxhp - 1;                     //次の体力(MAXHP-1)
        gdecrease = HpGreen.fillAmount / maxhp; //緑の減らす量(1/MAXHP)
    }

    // Update is called once per frame
    void Update()
    {
        ////プレイヤー以外　体力を減らす
        //if (WolfHPmanager.WolfHP1 == w1nexthp || WolfHPmanager.WolfHP2 == w2nexthp || WolfHPmanager.WolfHP3 == w3nexthp)  //残りのクリック回数と次の体力が一緒になったら
        //{
        //    if (decreaseFlag == false)//一度だけ減らす
        //    {
        //        HpGreen.fillAmount -= gdecrease;    //緑の体力を減らす
        //        Debug.Log("g");

        //        maxhp = nexthp;     //次の体力だったものが今のMAX体力になる
        //        nexthp = maxhp - 1; //次の体力


        //        decreaseFlag = true;
        //    }
        //}
        //else
        //    decreaseFlag = false;


        //ボスシーンPlayerHP　攻撃が重なった場合も含めて　体力を減らす処理       
        if (decreaseFlag == false && wolfManager.PHP == nexthp)         //1ダメージ
        {
            HpGreen.fillAmount -= gdecrease;    //緑の体力を減らす
            Debug.Log(HpGreen.fillAmount);

            maxhp = nexthp;     //次の体力だったものが今のMAX体力になる
            nexthp = maxhp - 1; //次の体力

            decreaseFlag = true;
        }
        else if (decreaseFlag == false && wolfManager.PHP == nexthp - 1)//2ダメージ
        {
            HpGreen.fillAmount -= gdecrease * 2;    //緑の体力を減らす
            Debug.Log(HpGreen.fillAmount);

            nexthp -= 1;
            maxhp = nexthp;     //次の体力だったものが今のMAX体力になる
            nexthp = maxhp - 1; //次の体力

            decreaseFlag = true;
        }
        else if (decreaseFlag == false && wolfManager.PHP == nexthp - 2)//3ダメージ
        {
            HpGreen.fillAmount -= gdecrease * 3;    //緑の体力を減らす
            Debug.Log(HpGreen.fillAmount);

            nexthp -= 2;
            maxhp = nexthp;     //次の体力だったものが今のMAX体力になる
            nexthp = maxhp - 1; //次の体力

            decreaseFlag = true;
        }
        decreaseFlag = false;
    }
}

