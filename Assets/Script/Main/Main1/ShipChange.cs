using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipChange : MonoBehaviour
{
    public Sprite newSprite;
    private SpriteRenderer image;
    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.ClearFlg)
        {
            image.sprite = newSprite;
            anim.SetBool("Clear", true);
        }
    }
}
