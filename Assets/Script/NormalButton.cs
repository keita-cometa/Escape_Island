using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalButton : MonoBehaviour
{
    public GameObject normalbutton;
    public GameObject text;
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Click()
    {
        GameManager.Hellmode = false;
        text.SetActive(false);
        audioSource.PlayOneShot(se);
    }
}
