using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hellmode : MonoBehaviour
{
    //public GameObject HellButton;
    // Start is called before the first frame update

    public GameObject text;
    public GameObject NormalButton;
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    void Start()
    {
        //Color Bcolor = HellButton.GetComponent<Renderer>().material.color;
        //Bcolor.a = 0.05f;
        //HellButton.GetComponent<Renderer>().material.color = Bcolor;
        audioSource = GetComponent<AudioSource>();
        text.SetActive(false);
        NormalButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.ClearFlg)
        {
            //Color Bcolor = HellButton.GetComponent<Text>().material.color;
            //Bcolor.a = 1f;
            //HellButton.GetComponent<Renderer>().material.color = Bcolor;
        }
    }
    public void Click()
    {
        
        GameManager.Hellmode = true;
        audioSource.PlayOneShot(se);
        text.SetActive(true);
        NormalButton.SetActive(true);
    }
}
