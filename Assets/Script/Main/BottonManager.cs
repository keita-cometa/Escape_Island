using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonManager : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject Button;
    public GameObject Yazirusi;

    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        Yazirusi.SetActive(false);
        if(GameManager.BowFlg)
        {
            Yazirusi.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Battele1Flg)
        {
            Yazirusi.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {      
        if(!PlayerController.isMoving)
        {
            if (GameManager.Battele1Flg)//バトルフラグ１がtrueになったら
            {
                panel2.SetActive(true);
            }
            if(!GameManager.Battele1Flg)
            {
                panel1.SetActive(true);
            }
            
        }
     }

    private void OnTriggerExit2D(Collider2D collision)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
    }


}
