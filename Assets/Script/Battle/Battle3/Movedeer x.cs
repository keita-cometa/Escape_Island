using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedeer : MonoBehaviour
{
    public GameObject player;  //�@動かしたいオブジェクトをインスペクターから入れる。
    public Transform movepointA;
    public Transform movepointB;
    public int speed = 5;  //オブジェクトが自動で動くスピード調整
    Vector3 movePosition;  //�Aオブジェクトの目的地を保存

    void Start()
    {
        movePosition = moveRandomPosition();  //�A実行時、オブジェクトの目的地を設定
    }

    void Update()
    {
        if (movePosition == player.transform.position)  //�Aplayerオブジェクトが目的地に到達すると、
        {
            movePosition = moveRandomPosition();  //�A目的地を再設定
        }
        this.player.transform.position = Vector3.MoveTowards(player.transform.position, movePosition, speed * Time.deltaTime);  //�@�Aplayerオブジェクトが, 目的地に移動, 移動速度
    
    }

    private Vector3 moveRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 randomPosi = new Vector3(Random.Range(movepointA.position.x, movepointB.position.x), Random.Range(movepointA.position.y, movepointB.position.y), 5);
        return randomPosi;
    }
}
