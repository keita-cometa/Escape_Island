using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;
    public float speed=4;
    public float updown=0;
    float rad;
    private Transform snake1;
    //private bool moving = true;

    int radpos;
    public GameObject clickedGameObject;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        snake1 = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //しるしをクリックしたときの動作
        if (Ssirusi.sign == true)
        {
            Instantiate(hitPrefab, transform.position, Quaternion.identity);
            audioSource.PlayOneShot(se);
            Invoke("hyouzi", 3.0f);
            Ssirusi.sign = false;
        }

        //蛇行の幅調整
        rad += 0.1f;
        if(rad>360)
        {
            rad = 0;
        }

        //現在位置保存
        pos = transform.position;

        // （ポイント）マイナスをかけることで逆方向に移動する。
        transform.Translate(transform.right * Time.deltaTime * speed * num);
        transform.Translate(transform.up * Time.deltaTime * speed * updown);
        if (pos.x > -2)
        {
            num = -1;
        }
        updown = Mathf.Sin(rad);
        if(pos.x<-12)
        {
            radpos = Random.Range(1, 5);
            //赤ならテレポート
            if (radpos == 1)
                    snake1.localPosition = new Vector2(11, 2);
            if (radpos == 2)
                    snake1.localPosition = new Vector2(11, 0);
            if (radpos == 3)
                    snake1.localPosition = new Vector2(11, -2);
            if (radpos == 4)
                    snake1.localPosition = new Vector2(11, -3);
            
        }
        
        if(pos.y>5)
        {
            radpos = Random.Range(1, 5);
            if (radpos == 1)
                snake1.localPosition = new Vector2(11, 2);
            if (radpos == 2)
                snake1.localPosition = new Vector2(11, 0);
            if (radpos == 3)
                snake1.localPosition = new Vector2(11, -2);
            if (radpos == 4)
                snake1.localPosition = new Vector2(11, -3);
            
        }
        if(pos.y<-7)
        {
            radpos = Random.Range(1, 5);
            if (radpos == 1)
                snake1.localPosition = new Vector2(11, 2);
            if (radpos == 2)
                snake1.localPosition = new Vector2(11, 0);
            if (radpos == 3)
                snake1.localPosition = new Vector2(11, -2);
            if (radpos == 4)
                snake1.localPosition = new Vector2(11, -3);
            updown = Random.Range(1, 2);
        }

        speed += 0.001f;
        if(Ssirusi.Sclearnum==6)
        {
            speed = 7f;
        }
        //if (Input.GetMouseButtonDown(0))
        //{

        //    clickedGameObject = null;

        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        //    if (hitSprite == true)
        //    {
        //        clickedGameObject = hitSprite.transform.gameObject;
        //        if (clickedGameObject.tag == "snake")
        //        {
        //            Destroy(clickedGameObject);
        //        }
        //    }
        //}
    }

    //接触判定
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    radpos = Random.Range(1, 5);
    //    //赤ならテレポート
    //    if (collision.gameObject.tag == "left")
    //    {
    //        if (radpos == 1)
    //            snake1.localPosition = new Vector2(11, 2);
    //        if (radpos == 2)
    //            snake1.localPosition = new Vector2(11, 0);
    //        if (radpos == 3)
    //            snake1.localPosition = new Vector2(11, -2);
    //        if (radpos == 4)
    //            snake1.localPosition = new Vector2(11, -3);
    //    }
    //}
    void hyouzi()
    {
        clickedGameObject.SetActive(true);
        
    }
}
