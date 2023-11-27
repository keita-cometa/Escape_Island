using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedeer : MonoBehaviour
{
    public GameObject target;//ランダムな場所
    public static float speed = 0.01f;//移動速度
    public static Vector2 transformpos;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {            
        
    }
    private void FixedUpdate()
    {
        //クリックされたらスピードアップ
        if (Touch.click == true)
        {
            speed = 0.2f;
        }
        //通常のスピード
        else
        {
            speed = 0.1f;
        }

        //movepointを追いかける
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed);
    }
}