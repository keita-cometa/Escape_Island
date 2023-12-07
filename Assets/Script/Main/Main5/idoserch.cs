using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idoserch : MonoBehaviour
{
    public GameObject idoText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        idoText.SetActive(true);
        Invoke("hide", 2.0f);
    }
    void hide()
    {
        idoText.SetActive(false);
    }
}
