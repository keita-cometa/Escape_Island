using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effector : MonoBehaviour
{
    public GameObject Wolf1;
    public GameObject Wolf2;
    public GameObject Wolf3;

    Vector3 wolf1pos;
    Vector3 wolf2pos;
    Vector3 wolf3pos;

    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wolf1pos = Wolf1.transform.position;
        wolf2pos = Wolf2.transform.position;
        wolf3pos = Wolf3.transform.position;
        
        if(WeakPoint.hit1)
        {
            Instantiate(hitPrefab, wolf1pos, Quaternion.identity);
            WeakPoint.hit1 = false;
        }
        else if(WeakPoint.hit2)
        {
            Instantiate(hitPrefab, wolf2pos, Quaternion.identity);
            WeakPoint.hit2 = false;
        }
        else if(WeakPoint.hit3)
        {
            Instantiate(hitPrefab, wolf3pos, Quaternion.identity);
            WeakPoint.hit3 = false;
        }
    }
}
