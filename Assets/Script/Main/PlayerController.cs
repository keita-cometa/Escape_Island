using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static Vector2 HeroPosition;//主人公の位置保存用変数
    public static bool isMoving;// 移動中判定

    bool other_obj;//ほかのオブジェクトがないかの判定
    public LayerMask WallLayer;//WallLayerを設定

    Vector2 input;

    //移動スピード
    [SerializeField] float moveSpeed;

    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        if(GoalManager.BattleClearFlg1)
        transform.position = HeroPosition;//保存した位置を開始時に呼び出す
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

            // キーボードの入力情報をinputに格納
            input.x = Input.GetAxisRaw("Horizontal")*2.0f; // 横方向
            input.y = Input.GetAxisRaw("Vertical")*2.0f;  // 縦方向

            // 入力があった時
            if (input != Vector2.zero)
            {
                // 入力があった分を目的地にする
                Vector2 targetPos = transform.position;
                targetPos += input;


                //他のコライダーがないかの判定
                if(input.y<0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position - (transform.up * 2.0f), WallLayer);//下方向
                else if(input.y>0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position + (transform.up * 2.0f), WallLayer);//上方向
                else if (input.x < 0)
                    other_obj = Physics2D.Linecast(transform.position - (transform.right * 2.0f), transform.position,WallLayer);//左方向
                else if (input.x > 0)
                    other_obj = Physics2D.Linecast(transform.position + (transform.right * 2.0f), transform.position, WallLayer);//右方向


                //ほかのコライダーがないとき移動を開始する
                if (!other_obj)
                StartCoroutine(Move(targetPos));

                
            }
        }
        HeroPosition = this.transform.position;//現在の位置を保存する

        //アニメーション制御
        //float horizontalKey = Input.GetAxis("Horizontal");
        //float verticalKey = Input.GetAxis("Vertical");

        if (isMoving)
        {
            if (input.x > 0)
            {
                anim.SetBool("Vecright", true);
                anim.SetBool("Vecleft", false);
                anim.SetBool("Vecup", false);
            }
            else if (input.x < 0)
            {
                
                anim.SetBool("Vecleft", true);
                anim.SetBool("Vecright", false);
                anim.SetBool("Vecup", false);
            }
            else if (input.y > 0)
            {
                anim.SetBool("Vecup", true);
                anim.SetBool("Vecright", false);
                anim.SetBool("Vecleft", false);
            }
            else if(input.y<0)
            {
                
                    anim.SetBool("Vecup", false);
                    anim.SetBool("Vecright", false);
                    anim.SetBool("Vecleft", false);
                
            }
        }

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
    }

    
}
