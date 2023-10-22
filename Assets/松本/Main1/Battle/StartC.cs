using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartC : MonoBehaviour
{
    public bool gameplay;

    // Start is called before the first frame update
    void Start()
    {
        gameplay = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        gameplay = true;
    }
}
