using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puropera : MonoBehaviour
{
    public GameObject puroperaButton;

    // Start is called before the first frame update
    void Start()
    {
        puroperaButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameManager.Battele4_1Flg&&GameManager.Battele4_2Flg)
        {
            puroperaButton.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        puroperaButton.SetActive(false);
    }
}
