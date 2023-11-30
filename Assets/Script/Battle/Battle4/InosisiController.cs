using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InosisiController : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;

    bool voke=true;
    public float speed = 1f;　　　　　// 移動速度

    public GameObject clickedGameObject;

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

       

    }

    void Speed()
    {
        // 移動速度をランダムに
        speed = Random.Range(5.0f, 15.0f);
        
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
