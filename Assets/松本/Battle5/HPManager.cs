using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{
    public Text HPtext;//HPの残り表示テキスト

    public WolfManager wolfManager;

    // Start is called before the first frame update
    void Start()
    {
        HPtext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //現在ののこりHP表示
        HPtext.text = wolfManager.PHP.ToString("0");
    }

    public void Attack()
    {
        wolfManager.PHP--;
    }
}
