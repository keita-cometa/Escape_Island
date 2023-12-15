using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public GameObject GameClear;
    public GameObject atogaki;
    public GameObject titleButton;
    public GameObject Omake;

    // Start is called before the first frame update
    void Start()
    {
        GameClear.SetActive(true);
        atogaki.SetActive(false);
        titleButton.SetActive(false);
        Omake.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("next", 3.0f);
    }

    void next()
    {
        GameClear.SetActive(false);
        atogaki.SetActive(true);
        Invoke("End", 3.0f);
    }

    void End()
    {
        titleButton.SetActive(true);
        Omake.SetActive(true);
    }
}
