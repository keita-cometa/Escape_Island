using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timing : MonoBehaviour
{
    bool Pushkey = false;
    public GameObject obj;
    public GameObject[] destroyobj;
    bool[] objflag = { false, false, false };

    static public int Mclear_cnt = 0;

    //オーディオ
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        //Pushkey = false;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Tonkachi") && objflag[0] == false)
        {
            destroyobj[0] = collision.transform.gameObject;
            objflag[0] = true;
        }
        else if(collision.CompareTag("Tonkachi")  &&objflag[1] == false)
        {
            destroyobj[1] = collision.transform.gameObject;
            objflag[1] = true;
        }
        else if (collision.CompareTag("Tonkachi") && objflag[2] == false)
        {
            destroyobj[2] = collision.transform.gameObject;
            objflag[2] = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Tonkachi") && objflag[0] == true)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                if (Pushkey == false)
                {
                    Pushkey = true;
                    Destroy(destroyobj[0]);
                    CraftMain.MCrear--;
                    audioSource.PlayOneShot(se);
                }
            }
            else
                Pushkey = false;
        }      
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Tonkachi") && objflag[0] == true)
        {
            objflag[0] = false;
            destroyobj[0] = destroyobj[1];
        }
        if (collision.CompareTag("Tonkachi") && objflag[1] == true)
        {
            objflag[1] = false;
            destroyobj[1] = destroyobj[2];

        }
        if (collision.CompareTag("Tonkachi") && objflag[2] == true)
        {
            objflag[2] = false;
        }
    }
        // Update is called once per frame
    void Update()
    {
        
    }
    
}
