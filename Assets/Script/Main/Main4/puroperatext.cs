using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puroperatext : MonoBehaviour
{
    public GameObject puropera;
    public GameObject puroperaButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void text()
    {
        puropera.SetActive(true);
        Invoke("hide", 2.0f);
        puroperaButton.SetActive(false);
        GameManager.puroperaFlg = true;
    }

    void hide()
    {
        puropera.SetActive(false);
    }
}
