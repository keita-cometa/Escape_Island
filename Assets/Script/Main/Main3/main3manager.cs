using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main3manager : MonoBehaviour
{
    public GameObject main4yazirusi;
    public GameObject main5yazirusi;

    // Start is called before the first frame update
    void Start()
    {
        main4yazirusi.SetActive(false);
        main5yazirusi.SetActive(false);
        if(GameManager.Battele3Flg)
        {
            main4yazirusi.SetActive(true);
        }
        if(GameManager.Battele5Flg)
        {
            main5yazirusi.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Battele3Flg)
        {
            main4yazirusi.SetActive(true);
        }
        if (GameManager.Battele5Flg)
        {
            main5yazirusi.SetActive(true);
        }
    }
}
