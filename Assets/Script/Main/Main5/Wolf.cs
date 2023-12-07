using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wolf : MonoBehaviour
{
    public string sceneName;
    private AudioSource audioSource;
    public GameObject Wolfs;

    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Wolfs.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Battele5Flg==true)
        {
            Wolfs.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController.stop = true;
            audioSource.PlayOneShot(se);
            Invoke("Load", 2.0f);
       
    }

    void Load()
    {
        SceneManager.LoadScene(sceneName);
        ChangeScene1.batnum = 6;
        ChangeScene1.posnum = 0;
        PlayerController.stop = false;
    }

}
