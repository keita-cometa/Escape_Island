using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMain : MonoBehaviour
{
    static public int MCrear = 10;
    static public bool MCrearFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MCrear==0)
        {
            MCrearFlag = true;

        }
    }
}
