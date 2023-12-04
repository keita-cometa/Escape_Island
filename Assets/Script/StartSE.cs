using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSE : MonoBehaviour
{
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
    public void startSE()
    {
        audioSource.PlayOneShot(se);
    }
}
