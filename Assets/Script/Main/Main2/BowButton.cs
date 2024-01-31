using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowButton : MonoBehaviour
{
    public GameObject itemtext;
    public GameObject Button;
    public GameObject Yazirusi;
    public GameObject M_back;   //É~ÉjÉQÅ[ÉÄópîwåi

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.BowFlg)
        {
            Button.SetActive(false);
            Yazirusi.SetActive(true);
        }
        Yazirusi.SetActive(false);
        itemtext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UI()
    {
        itemtext.SetActive(true);
        Button.SetActive(false);
        Yazirusi.SetActive(true);
        GameManager.BowFlg = true;
        M_back.SetActive(true);

        Invoke("hide",2.0f);
    }

    void hide()
    {
        itemtext.SetActive(false);
    }
}
