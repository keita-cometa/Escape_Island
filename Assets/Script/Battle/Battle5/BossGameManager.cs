using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossGameManager : MonoBehaviour
{
    public string sceneName;//ì«Ç›çûÇﬁÉVÅ[Éìñº
    public GameObject ClearUI;
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        num = WolfManager.wolfnum;
        if (WolfManager.wolfnum==3)
        {
            ClearUI.SetActive(true);
            audioSource.PlayOneShot(se);
            Invoke("end", 2.0f);
        }
    }
    void end()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele5Flg = true;
    }
}
