using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puroperatext : MonoBehaviour
{
    public GameObject puropera;
    public GameObject puroperaButton;
    public GameObject misstext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void text()
    {
        if(GameManager.Battele4_1Flg&&GameManager.Battele4_2Flg)
        {
            puropera.SetActive(true);
            Invoke("hide", 2.0f);
            puroperaButton.SetActive(false);
            GameManager.puroperaFlg = true;
        }
        else
        {
            misstext.SetActive(true);
            Invoke("hide", 2.0f);
        }
        
    }

    void hide()
    {
        puropera.SetActive(false);
        misstext.SetActive(false);
    }
}
