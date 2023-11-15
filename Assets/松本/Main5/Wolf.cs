using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wolf : MonoBehaviour
{
    public string sceneName;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            audioSource.PlayOneShot(se);
            Invoke("Load", 3.0f);
       
    }

    void Load()
    {
        SceneManager.LoadScene(sceneName);
    }

}
