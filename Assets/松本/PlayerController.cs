using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 移動中判定
    bool isMoving; 

    Vector2 input;

    //移動スピード
    [SerializeField] float moveSpeed;

    //ほかのオブジェクトがないかの判定
    bool other_obj;

    //X軸の移動範囲
    [SerializeField] private float min_x = -8.0f;
    [SerializeField] private float max_x = 8.0f;

    //Y軸の移動範囲
    [SerializeField] private float min_y = -4.5f;
    [SerializeField] private float max_y = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 移動中だと入力を受け付けない
        if (!isMoving)
        {
            // キーボードの入力情報をinputに格納
            input.x = Input.GetAxisRaw("Horizontal")*2.05f; // 横方向
            input.y = Input.GetAxisRaw("Vertical")*2.05f;  // 縦方向

            // 入力があった時
            if (input != Vector2.zero)
            {
                // 入力があった分を目的地にする
                Vector2 targetPos = transform.position;
                targetPos += input;

                
                if(!other_obj)
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        other_obj = true;
    }

}
