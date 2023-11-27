using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;

    private Transform snake1;
    //private bool moving = true;

    int radpos;
    public GameObject clickedGameObject;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        snake1 = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Ssirusi.sign == true)
        {
            audioSource.PlayOneShot(se);
            Invoke("hyouzi", 3.0f);
            Ssirusi.sign = false;
        }

        pos = transform.position;

        // （ポイント）マイナスをかけることで逆方向に移動する。
        transform.Translate(transform.right * Time.deltaTime * 3 * num);

        if (pos.x > -2)
        {
            num = -1;
        }

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        radpos = Random.Range(1, 5);
        //赤ならテレポート
        if (collision.gameObject.tag == "left")
        {
            if (radpos == 1)
                snake1.localPosition = new Vector2(11, 2);
            if (radpos == 2)
                snake1.localPosition = new Vector2(11, 0);
            if (radpos == 3)
                snake1.localPosition = new Vector2(11, -2);
            if (radpos == 4)
                snake1.localPosition = new Vector2(11, -3);
        }
    }
    void hyouzi()
    {
        clickedGameObject.SetActive(true);
        
    }
}
