
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform target;
    public static Vector2 HeroPosition;//主人公の位置保存用変数
    public static bool isMoving;// 移動中判定

    bool other_obj;//ほかのオブジェクトがないかの判定
    public LayerMask WallLayer;//WallLayerを設定

    Vector2 input;

    //移動スピード
    [SerializeField] float moveSpeed;

    private Animator anim = null;

    Vector3 RightUP = new Vector2(6.5f, 3.5f);
    Vector3 RightDown = new Vector2(6.5f, -4.5f);
    Vector3 LeftUP = new Vector2(-9.5f, 3.5f);
    Vector3 LeftDown = new Vector2(-9.5f, -4.5f);

    bool kadoueFlg;
    bool kadositaFlg;

    // Start is called before the first frame update
    void Start()
    {
      
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //移動制御
        // 移動中だと入力を受け付けない
        if (!isMoving)
        {
            //判定の初期化
            other_obj = false;
            Vector2 pos = transform.position;

            //Vector2 direction;
            input = target.position - transform.position;
            Debug.Log(target.position + "taget");
            Debug.Log(transform.position + "enemy");
            Debug.Log(input + "kyori");


            if (transform.position == RightUP || transform.position == LeftUP)
            {
                kadoueFlg = true;
            }
            if (transform.position == RightDown || transform.position == LeftDown)
            {
                kadositaFlg = true;
            }

            if (target.position == transform.position)
            {
                //transform.localScale = transform.localScale;//画像はそのまま
                return;
            }
            else if (input.x >= input.y && input.x > 0)
            {
                Debug.Log("xみぎ");
                pos.x -= 2.0f;
                pos.y += 0.0f;
               // transform.localScale = new Vector2(-0.3f, 0.3f);  //画像反転
            }
            else if (input.x < input.y && input.x < 0)
            {
                Debug.Log("xひだり");
                pos.x += 2.0f;
                pos.y += 0.0f;
                //transform.localScale = new Vector2(0.3f, 0.3f);  //画像反転
            }
            else if (input.x <= input.y && input.y > 0)
            {
                Debug.Log("yうえ");
                pos.x += 0.0f;
                pos.y -= 2.0f;
            }
            else if (input.x > input.y && input.y < 0)
            {
                Debug.Log("yした");
                pos.x += 0.0f;
                pos.y += 2.0f;
            }
            //else if()
            //{
            //    if(transform.position.x>0&&transform.position.y>0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y += 2.0f;
            //    }
            //    else if(transform.position.x < 0 && transform.position.y > 0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y += 2.0f;
            //    }
            //    else if(transform.position.x < 0 && transform.position.y < 0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y -= 2.0f;
            //    }
            //    else if(transform.position.x > 0 && transform.position.y < 0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y -= 2.0f;
            //    }
            //}
            // キーボードの入力情報をinputに格納
            // input.x = Input.GetAxisRaw("Horizontal") * 2.0f; // 横方向
            //  input.y = Input.GetAxisRaw("Vertical") * 2.0f;  // 縦方向

            // 入力があった時
            if (input != Vector2.zero)
            {
                // 入力があった分を目的地にする
                Debug.Log("if");

                //他のコライダーがないかの判定
                if (input.y > 0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position - (transform.up * 2.0f), WallLayer);//下方向
                else if (input.y <0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position + (transform.up * 2.0f), WallLayer);//上方向
                else if (input.x > 0)
                {
                    other_obj = Physics2D.Linecast(transform.position - (transform.right * 2.0f), transform.position, WallLayer);//左方向
                    Debug.Log("kabe");
                }
               
                else if (input.x < 0)
                {
                    other_obj = Physics2D.Linecast(transform.position + (transform.right * 2.0f), transform.position, WallLayer);//右方向
                    Debug.Log("kabe");
                }


                //||kadoueFlg==true||kadositaFlg==true

                //ほかのコライダーがないとき移動を開始する
                if (!other_obj)
                    StartCoroutine(Move(pos));
                


            }
        }
        HeroPosition = this.transform.position;//現在の位置を保存する

        //アニメーション制御
        //float horizontalKey = Input.GetAxis("Horizontal");
        //float verticalKey = Input.GetAxis("Vertical");

        //if (isMoving)
        //{
        //    if (input.x > 0)
        //    {
        //        anim.SetBool("Vecright", true);
        //        anim.SetBool("Vecleft", false);
        //        anim.SetBool("Vecup", false);
        //    }
        //    else if (input.x < 0)
        //    {

        //        anim.SetBool("Vecleft", true);
        //        anim.SetBool("Vecright", false);
        //        anim.SetBool("Vecup", false);
        //    }
        //    else if (input.y > 0)
        //    {
        //        anim.SetBool("Vecup", true);
        //        anim.SetBool("Vecright", false);
        //        anim.SetBool("Vecleft", false);
        //    }
        //    else if (input.y < 0)
        //    {

        //        anim.SetBool("Vecup", false);
        //        anim.SetBool("Vecright", false);
        //        anim.SetBool("Vecleft", false);

        //    }
        //}

    }

    //　コルーチンを使って徐々に目的地に近づける
    IEnumerator Move(Vector3 targetPos)
    {
        // 移動中は入力を受け付けない
        isMoving = true;

        // targetposとの差があるなら繰り返す:目的地に辿り着くまで繰り返す
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            // targetPosに近づける
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            // 徐々に近づけるため
            yield return null;
        }

        // 移動処理が完了したら目的地に到着させる
        transform.position = targetPos;
        isMoving = false;
        kadositaFlg = false;
        kadoueFlg = false;
    }


}
