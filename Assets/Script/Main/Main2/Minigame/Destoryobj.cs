using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoryobj : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tonkachi"))
        {
            obj = collision.transform.gameObject;
            Destroy(obj);
        }

        obj = null;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
