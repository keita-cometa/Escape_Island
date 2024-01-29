using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject Panel;
    public bool Menuflg=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)&&Menuflg==false)
        {
            Panel.SetActive(true);
            Invoke("time", 1.0f);
        }
        if(Input.GetKey(KeyCode.M)&&Menuflg==true)
            {
            Panel.SetActive(false);
            Menuflg = false;
        }
    }
    void time()
    {
        Menuflg = true;
    }
}
