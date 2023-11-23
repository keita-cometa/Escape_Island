using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main5manager : MonoBehaviour
{
    public GameObject kirakira;
    public GameObject main3yazirusi;
    public GameObject wolfs;
    // Start is called before the first frame update
    void Start()
    {
        kirakira.SetActive(true);
        wolfs.SetActive(true);
        main3yazirusi.SetActive(false);
        if(GameManager.Battele5Flg)
        {
            wolfs.SetActive(false);
        }
        if (GameManager.GasFlg)
        {
            kirakira.SetActive(false);
            main3yazirusi.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.GasFlg)
        {
            kirakira.SetActive(false);
            main3yazirusi.SetActive(true);
        }
    }
}
