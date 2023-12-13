using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchsignB : MonoBehaviour
{
    GameObject clickGameObject;
    
    public static int goalnum=0;//目標個数
    
    public int cnt=1;//カウント変数
    public float wind;
    public static bool animFlg=false;

    private Rigidbody2D rbody2D;
    Vector2 pos;
    public bool windFlg=false;
    // Start is called before the first frame update   
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        cnt = 0;
        wind = Random.RandomRange(-1.3f, 1.3f);
    }


    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position;
        cnt = 0;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if(hitSprite==true)
            {
                clickGameObject = hitSprite.transform.gameObject;
                if(clickGameObject.tag == "signB"&&goalnum>0)
                {
                    Destroy(clickGameObject);
                    cnt++;
                    goalnum -= cnt;
                    animFlg = true;
                    Debug.Log("hit");
                }
            }
        }

        if (transform.position.y < 4)
        {
            this.rbody2D.AddForce(transform.right * wind);
            
        }
        
        
    }
   
}
