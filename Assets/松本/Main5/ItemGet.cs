using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGet : MonoBehaviour
{
    public GameObject GetText;

    // Start is called before the first frame update
    void Start()
    {
        GetText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UI()
    {
        GetText.SetActive(true);
        Invoke("Hidden", 4.0f);
        GameManager.GasFlg = true;
    }

    void Hidden()
    {
        GetText.SetActive(false);
    }
}
