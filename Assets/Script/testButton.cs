using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testButton : MonoBehaviour
{
    Color fadeColor = Color.black;
    float fadespeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        GameManager.ClearFlg = true;
        GameManager.Battele1Flg = true;
        GameManager.Battele3Flg = true;
        GameManager.Battele4_1Flg = true;
        GameManager.Battele4_2Flg = true;
        GameManager.Battele5Flg = true;
        GameManager.BowFlg = true;
        GameManager.HandleFlg = true;
        GameManager.puroperaFlg = true;
        GameManager.GasFlg = true;
        GameManager.woodFlg = true;
        Initiate.Fade("GameClearScene", fadeColor, fadespeed);
    }
}
