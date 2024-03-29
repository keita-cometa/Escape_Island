using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WolfManager : MonoBehaviour
{
    private Animator anim = null;

    public HPManager hpManager;

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
    public int PHP=10;//プレイヤーのHP変数

    //public int WolfHP1;//オオカミ1のHP変数
    //public int WolfHP2;//オオカミ2のHP変数
    //public int WolfHP3;//オオカミ3のHP変数
    public float activetime;//しるしがアクティブになるまでの時間
    public string sceneName;//呼び出すシーン名

    public static int wolfnum;//倒したオオカミを数える用
    public WolfHPmanager wolfManager;
    // Start is called before the first frame update
    void Start()
    {
        wolfnum = 0;
        movePosition = moveRandomPosition();//オブジェクトの目的地を設定
        anim = GetComponent<Animator>();
        if(GameManager.Hellmode)
        {
            PHP = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームが始まったら
        if(StartC.onclick)
        {
            keikatime += Time.deltaTime;
            //ウィークポイントの再表示
            if (!weakPoint.activeInHierarchy)
            {
                //ウィークポイントが消えてる状態になったらwalkにする
                anim.SetBool("Attack", false);
                //アクティブタイム経過したら再表示
                if (keikatime > activetime)
                {
                    Debug.Log("hyouzi");
                    weakPoint.SetActive(true);//再表示
                    keikatime = 0.0f;
                    anim.SetBool("Attack", false);//アニメーションをwalkに戻す
                }
            }
            else
            {
                //攻撃モーション開始
                if (keikatime > Attacktime - 1.0f)
                {
                    anim.SetBool("Attack", true);
                }
                //オオカミの攻撃
                if (keikatime > Attacktime)
                {
                    hpManager.Attack();
                    //wolfManager.damageSE();

                    //経過時間を0に戻す
                    keikatime = 0.0f;
                    anim.SetBool("Attack", false);

                }
            }
            
        }
        
        if(wolfnum==1)
        {
            movespeed = 7;
        }
        if(wolfnum==2)
        {
            movespeed = 8;
        }

        if (movePosition == Wolf.transform.position)  //オブジェクトが目的地に到達すると、
        {
            movePosition = moveRandomPosition();  //目的地を再設定
        }
        //オブジェクトが, 目的地に移動する
        this.Wolf.transform.position = Vector3.MoveTowards(Wolf.transform.position, movePosition, movespeed * Time.deltaTime);
        //左右反転させたりするアニメーション
        if(movePosition.x>Wolf.transform.position.x)
        {
            //右向き
            transform.localScale = new Vector3(-1, 1, 1);
            //anim.SetBool("Attack", false);
        }
        else
        {
            //左向き
            transform.localScale = new Vector3(1, 1, 1);
            //anim.SetBool("Attack", false);
        }
        //if (WolfHP == 0)
        //{
        //    wolfnum++;
        //    //HPが0になったらウルフを消す
        //    Wolf.SetActive(false);

        //}

        
    }

    private Vector3 moveRandomPosition()  
    {
        // 目的地を生成、xとyのポジションをランダムに値を取得 
        Vector3 randomPosi = new Vector3(Random.Range(leftPos, rightPos), Random.Range(bottomPos,topPos ), 0);

        //目的地を返す
        return randomPosi;
    }


    void GameOver()
    {
        SceneManager.LoadScene(sceneName);
    }

    //public void  Damage1()
    //{
    //    WolfHP1--;
    //}
}
