using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchsignB : MonoBehaviour
{
    GameObject clickGameObject;
    public static int goalnum;//目標個数
    public int cnt;//カウント変数
    // Start is called before the first frame update   
    void Start()
    {
          
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if(hitSprite==true)
            {
                clickGameObject = hitSprite.transform.gameObject;
                if(clickGameObject.tag == "signB")
                {
                    Destroy(clickGameObject);
                    cnt++;
                    goalnum -= cnt;
                }
            }
        }
    }
}
