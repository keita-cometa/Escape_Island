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
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(!PlayerController.isMoving&&!GameManager.puroperaFlg)
        {
            puroperaButton.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        puroperaButton.SetActive(false);
    }
}
