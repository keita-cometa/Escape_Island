using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    public GameObject target;//ランダムな場所

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < target.transform.position.x)             //自分の位置がランダムの移動場所より右側なら
        {

            transform.localScale = new Vector2(-1, 1);  //画像反転
        }
        else if (transform.position.x == target.transform.position.x)        //移動場所についたら
        {
            transform.localScale = transform.localScale;//画像はそのまま
        }
        else                                                                //左側なら
        {
            transform.localScale = new Vector2(1, 1);   //元の画像
        }
    }
}
