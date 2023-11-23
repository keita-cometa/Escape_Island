using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowButton : MonoBehaviour
{
    public GameObject itemtext;
    public GameObject Button;
    public GameObject Yazirusi;
    
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.BowFlg)
        {
            Yazirusi.SetActive(true);
        }
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

        Invoke("hide",2.0f);
    }

    void hide()
    {
        itemtext.SetActive(false);
    }
}
