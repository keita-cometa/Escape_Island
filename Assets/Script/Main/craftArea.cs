using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craftArea : MonoBehaviour
{
    public GameObject BowButton;
    public GameObject HandleButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!GameManager.BowFlg)
        {
            BowButton.SetActive(true);
        }
        if(GameManager.Battele3Flg)
        {
            HandleButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        BowButton.SetActive(false);
        HandleButton.SetActive(false);
    }
}
