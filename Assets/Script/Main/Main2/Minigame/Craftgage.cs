using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Craftgage : MonoBehaviour
{
    public Image HpGreen;   //緑のHPバー

    private bool decreaseFlag = false;  //減らすかどうかのフラグ

    private float gdecrease = 0;    //緑の減らす量
    private int maxhp = 0;          //現在ののMAX体力
    private int nexthp = 0;         //次の体力(MAX体力-1)

    // Start is called before the first frame update
    void Start()
    {
        gdecrease = 0;
        maxhp = -5;
        nexthp = -5;
        //HpGreen.fillAmount = 0.0f;
        Invoke("Initialization", 1.0f);//ゲージの初期化を遅らせる

    }

    void Initialization()
    {
        maxhp = CraftMain.MCrear;

        nexthp = maxhp - 1;                     //次の体力(MAXHP-1)
        gdecrease = 1.0f / maxhp; //緑の減らす量(1/MAXHP)

    }

    // Update is called once per frame
    void Update()
    {
        if (CraftMain.MCrear == nexthp)  //残りのクリック回数と次の体力が一緒になったら
        {
            Debug.Log("c");
            if (decreaseFlag == false)//一度だけ減らす
            {

                HpGreen.fillAmount += gdecrease;    //緑の体力を減らす
                Debug.Log("d");
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
