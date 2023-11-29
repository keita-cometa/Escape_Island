using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    public string sceneName;//読み込むシーン名
    public int mnum;
    public int bnum;
    public static int posnum;//呼び出す場所決定用
    public static int batnum;//リトライ用

    Color fadeColor = Color.black;
    float fadespeed=1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        Initiate.Fade(sceneName, fadeColor, fadespeed);
        posnum = mnum;
        batnum = bnum;
    }
}
