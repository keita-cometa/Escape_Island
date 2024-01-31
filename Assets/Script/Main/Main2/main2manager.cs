using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main2manager : MonoBehaviour
{
    public GameObject main3yazirusi;
    public GameObject bowtext;
    public GameObject handletext;

    // Start is called before the first frame update
    void Start()
    {
        main3yazirusi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.BowFlg)
        {
            main3yazirusi.SetActive(true);
        }
        if(CraftMain.MCrearFlag)
        {
            Invoke("Btext", 4.0f);
        }
    }

    void Btext()
    {
        bowtext.SetActive(false);
    }
}
