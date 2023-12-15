using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HellChange : MonoBehaviour
{
    public GameObject HellButton;
    // Start is called before the first frame update
    void Start()
    {
        Color Bcolor = HellButton.GetComponent<Text>().material.color;
        Bcolor.a = 1f;
        HellButton.GetComponent<Text>().material.color = Bcolor;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.ClearFlg)
        {
            Color Bcolor = HellButton.GetComponent<Text>().material.color;
            Bcolor.a = 1f;
            HellButton.GetComponent<Text>().material.color = Bcolor;
        }
    }
}
