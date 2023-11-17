using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //各ステージのフラグ管理
    public static bool Battele1Flg = false;
    public static bool Battele3Flg = false;
    public static bool Battele4Flg = false;
    public static bool Battele5Flg = false;

    //各シーンロード時の出現場所設定
    public static Vector3 M1_1pos = new Vector3(0, 0, 0);//メイン1の出現場所     1
    public static Vector3 M2_1pos = new Vector3(0, 0, 0);//メイン2の下の出現場所 2
    public static Vector3 M2_2pos = new Vector3(0, 0, 0);//メイン2の右の出現場所 3
    public static Vector3 M3_1pos = new Vector3(0, 0, 0);//メイン3の右の出現場所 4
    public static Vector3 M3_2pos = new Vector3(0, 0, 0);//メイン3の下の出現場所 5
    public static Vector3 M3_3pos = new Vector3(0, 0, 0);//メイン3の左の出現場所 6
    public static Vector3 M4_1pos = new Vector3(0, 0, 0);//メイン4の上の出現場所 7
    public static Vector3 M4_2pos = new Vector3(0, 0, 0);//メイン4の左の出現場所 8
    public static Vector3 M4_3pos = new Vector3(0, 0, 0);//メイン4の右の出現場所 9
    public static Vector3 M5_1pos = new Vector3(0, 0, 0);//メイン5の下の出現場所 10
    public static Vector3 M5_2pos = new Vector3(0, 0, 0);//メイン5の上の出現場所 11

    public static int Loadpos;//どの位置に出現するかの変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
