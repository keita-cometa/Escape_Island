using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public static bool BattleClearFlg1;//バトル１がクリアされたかどうかのフラグ
    public string sceneName;//読み込むシーン名

    public int plasnum;//10に足す個数設定
    public Text Goaltext;//クリア個数テキスト

    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        BattleClearFlg1 = false;
        TouchsignB.goalnum += plasnum;
    }

    // Update is called once per frame
    void Update()
    {
        //目標個数表示
        Goaltext.text = TouchsignB.goalnum.ToString("0");

        //goalnumが0になったらクリア関数を呼び出す
        if(TouchsignB.goalnum == 0)
        {
            Clear();
        }
    }

    //クリアしたときの関数
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        BattleClearFlg1 = true;
    }
}
