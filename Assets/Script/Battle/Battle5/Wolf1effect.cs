using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf1effect : MonoBehaviour
{
    public GameObject Wolf1;
    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void hiteffect()
    {
        Instantiate(hitPrefab, transform.position, Quaternion.identity);
    }
}
