using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttoncontro : MonoBehaviour
{
    public GameObject Button;

    // Start is called before the first frame update
    void Start()
    {
        Button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(!PlayerController.isMoving&&!GameManager.woodFlg)
            Button.SetActive(true);
    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Button.SetActive(false);
    }
}
