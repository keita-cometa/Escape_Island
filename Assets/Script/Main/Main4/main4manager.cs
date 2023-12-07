using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main4manager : MonoBehaviour
{
    public GameObject main5yazirusi;
    public GameObject snake;

    // Start is called before the first frame update
    void Start()
    {
        main5yazirusi.SetActive(false);
        if(GameManager.Battele4_1Flg&&GameManager.Battele4_2Flg)
        {
            main5yazirusi.SetActive(true);
        }
        if(GameManager.Battele4_2Flg)
        {
            snake.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Battele4_1Flg && GameManager.Battele4_2Flg)
        {
            main5yazirusi.SetActive(true);
        }
        if (GameManager.Battele4_2Flg)
        {
            snake.SetActive(false);
        }
    }
}
