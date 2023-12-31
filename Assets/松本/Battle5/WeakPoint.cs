using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoint : MonoBehaviour
{
    public GameObject weakPoint;//ウィークポイントオブジェクト
    public static int WHP;//オオカミのHP変数初期値10

    public static bool pointFlg = true;//ポイントがアクティブかどうか判定用

    public static bool hit1=false;
    public static bool hit2=false;
    public static bool hit3=false;

    private AudioSource audioSource;
    //public float activetime;//アクティブになるまでの時間

    public WolfHPmanager wolfManager;

    public Wolf1effect wolf1Effect;
    public Wolf2effect wolf2Effect;
    public Wolf3effect wolf3Effect;

    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
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
                Debug.Log("Ray");
                if (weakPoint.tag == "weak1")
                {
                    hit1 = true;
                    wolf1Effect.hiteffect();
                    Debug.Log("hit");
                    wolfManager.Damage1();
                    //ヒットしたときウィークポイントを一時的に隠す
                    weakPoint.SetActive(false);
                    wolfManager.hitSE();
                    //audioSource.PlayOneShot(se1);
                }
                else if (weakPoint.tag == "weak2")
                {
                    hit2 = true;
                    wolf2Effect.hiteffect();
                    Debug.Log("hit");
                    wolfManager.Damage2();
                    //ヒットしたときウィークポイントを一時的に隠す
                    weakPoint.SetActive(false);
                    wolfManager.hitSE();
                    //audioSource.PlayOneShot(se1);
                }
                else if (weakPoint.tag == "weak3")
                {
                    hit3 = true;
                    wolf3Effect.hiteffect();
                    Debug.Log("hit");
                    wolfManager.Damage3();
                    //ヒットしたときウィークポイントを一時的に隠す
                    weakPoint.SetActive(false);
                    wolfManager.hitSE();
                    //audioSource.PlayOneShot(se1);
                }
                
            }
            else
            {
                //audioSource.PlayOneShot(se2);
                wolfManager.missSE();
            }
        }
        
     
    }
}
