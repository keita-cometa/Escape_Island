using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftGame : MonoBehaviour
{
    public GameObject obj;
    //bool M_sceneFlag = false;

    float[,] timing = new float[,] {
        { 1.0f, 0.5f, 1.0f, 0.5f, 2.5f },
        { 1.0f, 0.5f, 0.5f, 1.0f, 2.5f },
        { 1.0f, 1.0f, 0.5f, 0.5f, 2.5f },
        { 1.0f, 1.0f, 1.0f, 1.0f, 2.5f }
    };//èoåªéûä‘ê›íË


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
            if (CraftMain.MCrearFlag == true)
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (StartC.onclick == true)
        {
            StartCoroutine(Spwan());
            StartC.onclick = false;
        }
    }
}
