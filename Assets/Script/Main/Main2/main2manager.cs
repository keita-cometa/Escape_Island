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
        CraftMain.MCrearFlag = false;
        main3yazirusi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.BowFlg)
        {
            main3yazirusi.SetActive(true);
        }
        if(CraftMain.MCrearFlag&&BowButton.bowflg)
        {
            Invoke("Btext", 4.0f);
        }
        if (CraftMain.MCrearFlag && HandleButton.handleflg)
        {
            Invoke("Htext", 4.0f);
        }
    }

    void Btext()
    {
        Debug.Log("btext");
        bowtext.SetActive(false);
        BowButton.bowflg = false;
    }
    void Htext()
    {
        Debug.Log("htext");
        handletext.SetActive(false);
        HandleButton.handleflg = false;
    }
}
