using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject clickGameObject;
    public float indication_time;
    public GameObject target;
    public static bool click;
    public GameObject Attackefect;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se1;


    public static int B3cnt=10;
    public static int hpcnt = 0;

    //エフェクト用
    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        clickGameObject.SetActive(true);
        B3cnt = 10;
        click = false;
        audioSource = GetComponent<AudioSource>();
        if(GameManager.Hellmode)
        {
            B3cnt = 13;
        }
    }

    //クリックされたら
    public void Onclick()
    {
        if(StartC.onclick)
        {
            //反応してほしくないとき
            if (click == true||StartC.starttf==false|| direction.obstacles == true)
            {

                Debug.Log("NO");
                return;
             }
            //反応したら
            else
            {
                Instantiate(hitPrefab, transform.position, Quaternion.identity);
                Debug.Log("cilck");
                click = true;
                StartCoroutine(Indication());
                B3cnt--;
                hpcnt++;
                audioSource.PlayOneShot(se1);
                Attackefect.SetActive(true);
                Invoke("hihyouzi", 1.0f);
            }
        }
        //else
        //{
        //    clickGameObject.layer = 0;
        //}
    }

    public IEnumerator Indication()
    {

        yield return new WaitForSeconds(indication_time);
        Touch.click = false;

        clickGameObject.transform.position = target.transform.position;
        //Debug.Log("a");

    }

    // Update is called once per frame
    void Update()
    {
        //しるし表示
        if (direction.obstacles == false && Touch.click == false)
        {
            clickGameObject.SetActive(true);
        }
        //非表示
        else if (direction.obstacles == true || Touch.click == true)
        {
            clickGameObject.SetActive(false);
            
        }
    }    

    void hihyouzi()
    {
        Attackefect.SetActive(false);
    }
}
