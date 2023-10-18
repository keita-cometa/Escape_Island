using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 移動中判定
    bool isMoving; 

    Vector2 input;
    Transform player;

    //移動スピード
    [SerializeField] float moveSpeed;

    //ほかのオブジェクトがないかの判定
    bool other_obj;

    // Start is called before the first frame update
    void Start()
    {
        player= GameObject.Find ("Hero").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // 移動中だと入力を受け付けない
        if (!isMoving)
        {
            //判定の初期化
            other_obj = false;

            // キーボードの入力情報をinputに格納
            input.x = Input.GetAxisRaw("Horizontal")*2.05f; // 横方向
            input.y = Input.GetAxisRaw("Vertical")*2.05f;  // 縦方向

            // 入力があった時
            if (input != Vector2.zero)
            {
                // 入力があった分を目的地にする
                Vector2 targetPos = transform.position;
                targetPos += input;

                Vector2 target_v = new Vector2(targetPos.x, targetPos.y);
                Vector2 Hero_pos = new Vector2(player.position.x, player.position.y);

                //Rayの作成
                Ray2D ray = new Ray2D(Hero_pos, target_v);
                //Raycastの作成
                RaycastHit2D hit= Physics2D.Raycast(ray.origin, ray.direction, 2.0f);

                //Rayが当たった時判定をtrueにする
                if (hit)
                {
                    other_obj = true;
                }
               
                //ほかのコライダーがないとき移動を開始する
                if (!other_obj)
                StartCoroutine(Move(targetPos));

                
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
