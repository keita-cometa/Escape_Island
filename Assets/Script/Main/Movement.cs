
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject deer;
    public Transform target;
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

    //上下左右の移動向き仮決定用
    bool UP=false;
    bool DOWN = false;
    bool RIGHT = false;
    bool LEFT = false;


    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    //ランダム移動用変数
    int radvec;
    //bool kadoueFlg;
    //bool kadositaFlg;

    // Start is called before the first frame update
    void Start()
    {
      if(GameManager.Battele3Flg)
        {
            deer.SetActive(false);
        }
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
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
            //Debug.Log(target.position + "taget");
            //Debug.Log(transform.position + "enemy");
            //Debug.Log(input + "kyori");


            //if (transform.position == RightUP || transform.position == LeftUP)
            //{
            //    kadoueFlg = true;
            //}
            //if (transform.position == RightDown || transform.position == LeftDown)
            //{
            //    kadositaFlg = true;
            //}

            //主人公から逃げる移動
            if ((-2<input.x&&input.x<2)||(-2<input.y&&input.y<2))
            {
                Debug.Log("nigeru");
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
                    LEFT = true;
                    // transform.localScale = new Vector2(-0.3f, 0.3f);  //画像反転
                }
                else if (input.x < input.y && input.x < 0)
                {
                    Debug.Log("xひだり");
                    pos.x += 2.0f;
                    pos.y += 0.0f;
                    RIGHT = true;
                    //transform.localScale = new Vector2(0.3f, 0.3f);  //画像反転
                }
                else if (input.x <= input.y && input.y > 0)
                {
                    Debug.Log("yうえ");
                    pos.x += 0.0f;
                    pos.y -= 2.0f;
                    DOWN = true;
                }
                else if (input.x > input.y && input.y < 0)
                {
                    Debug.Log("yした");
                    pos.x += 0.0f;
                    pos.y += 2.0f;
                    UP = true;
                }
            }
            //感知範囲外の時のランダム移動
            else
            {
                radvec = Random.Range(0, 4);
                if (radvec==0)
                {
                    Debug.Log("x左");
                    pos.x -= 2.0f;
                    pos.y += 0.0f;
                    LEFT = true;
                    // transform.localScale = new Vector2(-0.3f, 0.3f);  //画像反転
                }
                else if (radvec==1)
                {
                    Debug.Log("xみぎ");
                    pos.x += 2.0f;
                    pos.y += 0.0f;
                    RIGHT = true;
                    //transform.localScale = new Vector2(0.3f, 0.3f);  //画像反転
                }
                else if (radvec==2)
                {
                    Debug.Log("yした");
                    pos.x += 0.0f;
                    pos.y -= 2.0f;
                    DOWN = true;
                }
                else if (radvec==3)
                {
                    Debug.Log("yうえ");
                    pos.x += 0.0f;
                    pos.y += 2.0f;
                    UP = true;
                }
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


                //他のコライダーがないかの判定
                if (UP)
                {
                    other_obj = Physics2D.Linecast(transform.position, transform.position + (transform.up * 2.0f), WallLayer);//上方向
                    UP = false;
                }  
                else if (DOWN)
                {
                    other_obj = Physics2D.Linecast(transform.position, transform.position - (transform.up * 2.0f), WallLayer);//下方向
                    DOWN = false;
                }
                else if (RIGHT)
                {
                    other_obj = Physics2D.Linecast(transform.position + (transform.right * 2.0f), transform.position, WallLayer);//右方向
                    RIGHT = false;
                }
                else if (LEFT)
                {
                    other_obj = Physics2D.Linecast(transform.position - (transform.right * 2.0f), transform.position, WallLayer);//左方向
                    LEFT = false;
                }

                //||kadoueFlg==true||kadositaFlg==true

                //ほかのコライダーがないとき移動を開始する
                if (!other_obj)
                    StartCoroutine(Move(pos));
                


            }
        }

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
        //kadositaFlg = false;
        //kadoueFlg = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(se);
        PlayerController.stop = true;
        Invoke("encount", 2.0f);

    }
    void encount()
    {
        SceneManager.LoadScene("BattleScene3");
        ChangeScene1.posnum = 0;
        ChangeScene1.batnum = 3;
        PlayerController.stop = false;
    }
}
