using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titlefirst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Battele1Flg = false;
        GameManager.Battele3Flg = false;
        GameManager.Battele4_1Flg = false;
        GameManager.Battele4_2Flg = false;
        GameManager.Battele5Flg = false;
        GameManager.BowFlg = false;
        GameManager.HandleFlg = false;
        GameManager.puroperaFlg = false;
        GameManager.GasFlg = false;
        GameManager.woodFlg = false;
        GameManager.ClearFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
