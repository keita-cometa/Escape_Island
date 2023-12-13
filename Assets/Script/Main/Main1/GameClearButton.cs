using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearButton : MonoBehaviour
{
    public GameObject gasNo;
    public GameObject puroperaNo;
    public GameObject handleNo;
    public GameObject Escape;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void text()
    {
        if(!GameManager.HandleFlg)
        {
            handleNo.SetActive(true);
            Invoke("hide", 2.0f);
        }
        if(!GameManager.GasFlg)
        {
            gasNo.SetActive(true);
            Invoke("hide", 2.0f);
        }
        if(!GameManager.puroperaFlg)
        {
            puroperaNo.SetActive(true);
            Invoke("hide", 2.0f);
        }
        if(GameManager.HandleFlg&& GameManager.GasFlg&& GameManager.puroperaFlg)
        {
            Escape.SetActive(true);
            GameManager.ClearFlg = true;
            Invoke("Clear", 2.0f);
        }
    }

    void hide()
    {
        handleNo.SetActive(false);
        gasNo.SetActive(false);
        puroperaNo.SetActive(false);
    }

    public void Clear()
    {
        SceneManager.LoadScene("GameClearScene");
    }
}
