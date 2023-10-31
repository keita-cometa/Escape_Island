using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfManager : MonoBehaviour
{
    public GameObject Wolf;//オオカミ 
    public float movespeed;//移動速度

    public int topPos;//上方向の移動制限
    public int bottomPos;//下方向の移動制限
    public int leftPos;//左方向の移動制限
    public int rightPos;//右方向の移動制限

    Vector3 movePosition;//目的地設定

    float Attacktime;//攻撃を行うまでの時間設定

    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition();//オブジェクトの目的地を設定

        Attacktime = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (movePosition == Wolf.transform.position)  //オブジェクトが目的地に到達すると、
        {
            movePosition = moveRandomPosition();  //目的地を再設定
        }
        //オブジェクトが, 目的地に移動する
        this.Wolf.transform.position = Vector3.MoveTowards(Wolf.transform.position, movePosition, movespeed * Time.deltaTime);


    }

    private Vector3 moveRandomPosition()  
    {
        // 目的地を生成、xとyのポジションをランダムに値を取得 
        Vector3 randomPosi = new Vector3(Random.Range(leftPos, rightPos), Random.Range(bottomPos,topPos ), 5);

        //目的地を返す
        return randomPosi;
    }
}
