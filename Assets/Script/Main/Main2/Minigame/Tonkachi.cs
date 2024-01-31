using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tonkachi : MonoBehaviour
{
    static public bool Minigame = false;
    public GameObject obj;
    public float speed = 1.0f;
    bool M_sceneFlag = false;

    float[,] timing = new float[,] {
        { 1.0f, 0.5f, 1.0f, 0.5f, 2.5f },
        { 1.0f, 0.5f, 0.5f, 1.0f, 2.5f },
        { 1.0f, 1.0f, 0.5f, 0.5f, 2.5f },
        { 1.0f, 1.0f, 1.0f, 1.0f, 2.5f }
    };//出現時間設定

    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator Spwan()
    {
        while (true)
        {
            int i = Random.Range(0, 4);
            for (int j = 0; j < 5; j++)
            {
                obj.transform.position = new Vector2(9.0f, 1.5f);

                Instantiate(obj);

                yield return new WaitForSeconds(timing[i, j]);
            }

        }
    }


    void Update()
    {
        //ミニゲームが始まると移動開始
        if (Minigame == false)
        {
            StartCoroutine(Spwan());
            obj.transform.position += new Vector3(speed, 0, 1) * Time.deltaTime;
        }
    }
}
