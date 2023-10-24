using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnsignB : MonoBehaviour
{
    public GameObject createPrefab;
    public Transform Apoint;
    public Transform Bpoint;
    public float Spawntime;
    public int SpawnNum;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while(true)
        {
            float y1 = Random.Range(Apoint.position.y, Bpoint.position.y);
            float x1 = Random.Range(Apoint.position.x, Bpoint.position.x);

            
            Instantiate(createPrefab, new Vector3(x1, y1), createPrefab.transform.rotation);

            float y2 = Random.Range(Apoint.position.y, Bpoint.position.y);
            float x2 = Random.Range(Apoint.position.x, Bpoint.position.x);


            Instantiate(createPrefab, new Vector3(x2, y2), createPrefab.transform.rotation);

            yield return new WaitForSeconds(Spawntime);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
}
