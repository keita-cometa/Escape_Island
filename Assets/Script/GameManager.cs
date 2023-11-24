using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //各ステージのフラグ管理
    public static bool Battele1Flg   = false;//木
    public static bool Battele3Flg   = false;//鹿
    public static bool Battele4_1Flg = false;//イノシシ
    public static bool Battele4_2Flg = false;//蛇
    public static bool Battele5Flg   = false;//狼
    public static bool BowFlg        = false;//弓矢作ったかどうか判別
    public static bool HandleFlg     = false;//ハンドル作ったかどうか判別
    public static bool puroperaFlg   = false;//プロペラ取ったかどうか判別
    public static bool GasFlg        = false;//ガソリン取ったかどうか判別

    //各シーンロード時の出現場所設定
    public static Vector3 M1_1pos = new Vector3(-1.5f,  3.5f, 0);//メイン1の出現場所     1
    public static Vector3 M2_1pos = new Vector3(-1.5f, -4.5f, 0);//メイン2の下の出現場所 2
    public static Vector3 M2_2pos = new Vector3(-9.5f, -0.5f, 0);//メイン2の右の出現場所 3
    public static Vector3 M3_1pos = new Vector3( 6.5f, -0.5f, 0);//メイン3の右の出現場所 4
    public static Vector3 M3_2pos = new Vector3(-1.5f, -4.5f, 0);//メイン3の下の出現場所 5
    public static Vector3 M3_3pos = new Vector3(-9.5f, -0.5f, 0);//メイン3の左の出現場所 6
    public static Vector3 M4_1pos = new Vector3( 2.5f,  3.5f, 0);//メイン4の上の出現場所 7
    public static Vector3 M4_2pos = new Vector3(-9.5f,  1.5f, 0);//メイン4の左の出現場所 8
    public static Vector3 M5_1pos = new Vector3( 6.5f, -4.5f, 0);//メイン5の下の出現場所 9
    public static Vector3 M5_2pos = new Vector3( 6.5f,  3.5f, 0);//メイン5の上の出現場所 10

    public static int Loadpos;//メインシーンのどの位置に出現するかの変数

    public static int meinnum;//どのメインシーンに移動するかの変数
    public static int battelenum;//どのバトルシーンに移動するかの変数

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
