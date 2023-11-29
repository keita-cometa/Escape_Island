using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnsignB : MonoBehaviour
{

    public GameObject createPrefab;
    public GameObject[] SpawnPoint;
    public GameObject TouchSignA;
    public float Spawntime;
    public float time;
    public bool IsSpawn;
    

    // Start is called before the first frame update

    void Start()
    {
        //Debug.Log("ugoiteru");

    }

    IEnumerator Spawn()
    {
        time = 4.0f;
        while (SignA.ClickSignA)
        {
            IsSpawn = true;
            //ランダムで生成する場所の決定
            int RandSpawn = Random.Range(0, 4);


            //プレハブ化したオブジェクトの位置に決定した場所を入れる
            createPrefab.transform.position = SpawnPoint[RandSpawn].transform.position;
            
            //生成
            Instantiate(createPrefab);
            
            yield return new WaitForSeconds(Spawntime);

            time -= 1.0f;
            if(time<0)
            {
                TouchSignA.SetActive(true);
                SignA.ClickSignA = false;
                IsSpawn = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsSpawn)
        StartCoroutine(Spawn());
    }
}
