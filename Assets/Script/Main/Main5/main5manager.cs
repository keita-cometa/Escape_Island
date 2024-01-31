using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main5manager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    public GameObject kirakira;
    public GameObject main3yazirusi;
    public GameObject main4yazirusi;
    public GameObject wolfs;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        kirakira.SetActive(true);
        wolfs.SetActive(true);
        main3yazirusi.SetActive(false);
        main4yazirusi.SetActive(false);
        if(GameManager.Battele5Flg)
        {
            wolfs.SetActive(false);
            main4yazirusi.SetActive(true);
        }
        if (GameManager.GasFlg)
        {
            kirakira.SetActive(false);
            main3yazirusi.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.GasFlg)
        {
            kirakira.SetActive(false);
            main3yazirusi.SetActive(true);
            //audioSource.PlayOneShot(se);
        }
        if (GameManager.Battele5Flg)
        {
            wolfs.SetActive(false);
        }
        if (GameManager.GasFlg)
        {
            kirakira.SetActive(false);
            main3yazirusi.SetActive(true);
        }
    }
}
