using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deerhp : MonoBehaviour
{
    public Image HpGreen;   //緑のHPバー
    //public Image HpRed;     //赤のHPバー

    //private Battle3Clear deer;
    private bool decreaseFlag = false;  //減らすかどうかのフラグ

    float gdecrease;    //緑の減らす量
   // float rdecrease;    //赤の減らす量
    //float rdecreasedown = 0.01f;
    int maxhp;          //鹿のMAX体力
    int nexthp;         //次の体力(MAX体力-1)
    // Start is called before the first frame update
    void Start()
    {
        maxhp = Touch.B3cnt;                    //最初の体力
        nexthp = maxhp - 1;                     //次の体力
        gdecrease = HpGreen.fillAmount / maxhp; //緑の減らす量(1/MAXHP)
        //rdecrease = HpRed.fillAmount / maxhp; //赤の減らす量(1/MAXHP)
    }

    void RDecrease()
    {
        
    }


    // Update is called once per frame
    void Update()
    {         
        if (Touch.B3cnt == nexthp)  //残りのクリック回数と次の体力が一緒になったら
        {
            if (decreaseFlag == false)//一度だけ減らす
            {
                HpGreen.fillAmount -= gdecrease;    //緑の体力を減らす
                Debug.Log("g");

                //for (; HpRed.fillAmount <= HpRed.fillAmount - rdecrease;)//赤の体力を徐々に減らす
                //{
                //    Debug.Log("r");
                //    HpRed.fillAmount -= 0.01f;
                //}
           
                maxhp = nexthp;     //次の体力だったものが今のMAX体力になる
                nexthp = maxhp - 1; //次の体力

                decreaseFlag = true;
            }              
        }
        else
            decreaseFlag = false;
    }
}
