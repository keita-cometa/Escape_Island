using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WolfManager : MonoBehaviour
{
    public GameObject Wolf;//オオカミ 
    public GameObject weakPoint;//しるし
    public float movespeed;//移動速度

    public int topPos;//上方向の移動制限
    public int bottomPos;//下方向の移動制限
    public int leftPos;//左方向の移動制限
    public int rightPos;//右方向の移動制限
    Vector3 movePosition;//目的地設定

    public float keikatime;//経過時間用変数
    public float Attacktime;//攻撃を行うまでの時間設定
    public static int PHP=10;//プレイヤーのHP変数

    public float activetime;//しるしがアクティブになるまでの時間
    public string sceneName;//呼び出すシーン名

    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition();//オブジェクトの目的地を設定

    }

    // Update is called once per frame
    void Update()
    {
        //ゲームが始まったら
        if(StartC.onclick)
        {
           
            if(keikatime>Attacktime)
            {
                //プレイヤーのHPを減らす
                PHP--;
                Debug.Log("attack!");
                //経過時間を0に戻す
                keikatime = 0.0f;
                //プレイヤーのHPが0になったらゲームオーバーを呼び出す
                if (PHP == 0)
                {
                    GameOver();
                }
            }
        }
        

        if (movePosition == Wolf.transform.position)  //オブジェクトが目的地に到達すると、
        {
            movePosition = moveRandomPosition();  //目的地を再設定
        }
        //オブジェクトが, 目的地に移動する
        this.Wolf.transform.position = Vector3.MoveTowards(Wolf.transform.position, movePosition, movespeed * Time.deltaTime);

        if (WeakPoint.WHP == 0)
        {
            //HPが0になったらウルフを消す
            Wolf.SetActive(false);
        }

        //ウィークポイントの再表示
        if (!WeakPoint.pointFlg)
        {
            keikatime += Time.deltaTime;//経過時間を測定
            if (keikatime > activetime)
            {
                WeakPoint.pointFlg = true;
                weakPoint.SetActive(true);//再表示
                keikatime = 0.0f;
            }
        }
    }

    private Vector3 moveRandomPosition()  
    {
        // 目的地を生成、xとyのポジションをランダムに値を取得 
        Vector3 randomPosi = new Vector3(Random.Range(leftPos, rightPos), Random.Range(bottomPos,topPos ), 5);

        //目的地を返す
        return randomPosi;
    }


    void GameOver()
    {
        SceneManager.LoadScene(sceneName);
    }
}
