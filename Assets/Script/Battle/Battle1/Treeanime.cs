using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treeanime : MonoBehaviour
{
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SignA.ClickSignA)
        {
            Debug.Log("signA");
            anim.SetBool("start", true);
            Invoke("modore", 1.0f);
        }
    }

    void modore()
    {
        anim.SetBool("start", false);
    }
        

}
