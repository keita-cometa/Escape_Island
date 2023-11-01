using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoint : MonoBehaviour
{
    public GameObject weakPoint;//ウィークポイントオブジェクト
    public static int WHP=10;//オオカミのHP変数初期値10

    public float keikatime;//経過時間測定用
    public static bool pointFlg=true;//ポイントがアクティブかどうか判定用
    public float activetime;//アクティブになるまでの時間

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      if (Input.GetMouseButtonDown(0)&&StartC.onclick)
        {
            //クリックしたときRayを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitSprite == true)
            {
                //飛ばした先にゲームタグ（weak）がないか調べる
                weakPoint = hitSprite.transform.gameObject;
                if (weakPoint.tag == "weak")
                {
                    //ヒットしたときウィークポイントを一時的に隠す
                    weakPoint.SetActive(false);
                    WHP--;//オオカミのHPを減らす
                    pointFlg = false;
                    
                }
            }
        }
        
     
    }
}
