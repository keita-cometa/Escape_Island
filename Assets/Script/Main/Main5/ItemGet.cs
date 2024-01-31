using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGet : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject GetText;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        GetText.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UI()
    {
        GetText.SetActive(true);
        Invoke("Hidden", 2.0f);
        GameManager.GasFlg = true;
        //audioSource.PlayOneShot(se);
    }

    void Hidden()
    {
        GetText.SetActive(false);
    }
}
