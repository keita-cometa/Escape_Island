using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InosisiController : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;
    public int radnum;
    bool voke=true;
    public float speed = 1f;　　　　　// 移動速度

    public GameObject clickedGameObject;
    public Renderer InosisiSprite;
    public Renderer sirusiSprite;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(voke==true)
        {
            Invoke("Speed", 2.0f);
            voke = false;
        }
        if(Isirusi.sign==true)
        {
            Instantiate(hitPrefab, transform.position, Quaternion.identity);
            audioSource.PlayOneShot(se);
            Invoke("hyouzi", 2.0f);
            Isirusi.sign = false;
        }
        
        pos = transform.position;

        // （ポイント）マイナスをかけることで逆方向に移動する。
        transform.Translate(transform.right * Time.deltaTime * speed * num);
        transform.Translate(transform.up * Time.deltaTime * speed * radnum);
        //Debug.Log(speed);

        if (pos.x > 12)
        {
            num = -1;
            Speed();
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (pos.x < -12)
        {
            Speed();
            this.GetComponent<SpriteRenderer>().flipX = true;
            num = 1;
            
        }
        if(pos.y>3)
        {
            radnum = -1;
        }
        if(pos.y<-3)
        {
            radnum = 1;
        }

        //真ん中の茂みの重なり部分
        if((-2.5<pos.x&&pos.x<2.5)&&(-5<pos.y&&pos.y<-3.5))
        {
            InosisiSprite.sortingOrder = 4;
            sirusiSprite.sortingOrder = 6;
        }
        //左の茂みの重なり部分
        else if((-8<pos.x&&pos.x<-4.5)&&(-0.5<pos.y&&pos.y<0))
        {
            InosisiSprite.sortingOrder = 4;
            sirusiSprite.sortingOrder = 6;
        }
        //右の茂みの重なり部分
        else if((4.5<pos.x&&pos.x<8.5)&&(-2.5<pos.y&&pos.y<-1.75))
        {
            InosisiSprite.sortingOrder = 4;
            sirusiSprite.sortingOrder = 6;
        }
        else
        {
            InosisiSprite.sortingOrder = 1;
            sirusiSprite.sortingOrder = 2;
        }
    }

    void Speed()
    {
        // 移動速度をランダムに
        if(GameManager.Hellmode)
        {
            speed = Random.Range(7.0f, 15f);
        }
        else
        {
            speed = Random.Range(5.0f, 10.0f);
        }
        radnum= Random.Range(-1,2);//上下移動
        voke = true;
    }
    void hyouzi()
    {
        clickedGameObject.SetActive(true);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //   clickedGameObject.SetActive(false);
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    //if(sirusi.sign==true)
    //    {
    //        clickedGameObject.SetActive(true);
    //    }
        
    //}
}
