using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject yumiya;
    public GameObject handle;
    public GameObject puropera;
    public GameObject gasorin;

    // Start is called before the first frame update
    void Start()
    {
        Color Ycolor = yumiya.GetComponent<Renderer>().material.color;
        Ycolor.a = 0.5f;
        Color Hcolor = handle.GetComponent<Renderer>().material.color;
        Hcolor.a = 0.5f;
        Color Pcolor = puropera.GetComponent<Renderer>().material.color;
        Pcolor.a = 0.5f;
        Color Gcolor = gasorin.GetComponent<Renderer>().material.color;
        Gcolor.a = 0.5f;

        yumiya.GetComponent<Renderer>().material.color   = Ycolor;
        handle.GetComponent<Renderer>().material.color   = Hcolor;
        puropera.GetComponent<Renderer>().material.color = Pcolor;
        gasorin.GetComponent<Renderer>().material.color  = Gcolor;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.BowFlg)
        {
            Color Ycolor = yumiya.GetComponent<Renderer>().material.color;
            Ycolor.a = 1;
            yumiya.GetComponent<Renderer>().material.color = Ycolor;
        }
        if(GameManager.HandleFlg)
        {
            Color Hcolor = handle.GetComponent<Renderer>().material.color;
            Hcolor.a = 1;
            handle.GetComponent<Renderer>().material.color = Hcolor;
        }
        if(GameManager.puroperaFlg)
        {
            Color Pcolor = puropera.GetComponent<Renderer>().material.color;
            Pcolor.a = 1;
            puropera.GetComponent<Renderer>().material.color = Pcolor;
        }
        if(GameManager.GasFlg)
        {
            Color Gcolor = gasorin.GetComponent<Renderer>().material.color;
            Gcolor.a = 1;
            gasorin.GetComponent<Renderer>().material.color = Gcolor;
        }
    }
}
