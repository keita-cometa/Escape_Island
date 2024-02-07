using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHPmanager : MonoBehaviour
{
    public GameObject Wolf1;
    public GameObject Wolf2;
    public GameObject Wolf3;

    public GameObject ya1;
    public GameObject ya2;
    public GameObject ya3;

    public static int WolfHP1=10;
    public static int WolfHP2=10;
    public static int WolfHP3=10;

    public int wolf1;
    public int wolf2;
    public int wolf3;

    Vector3 wolf1pos;
    Vector3 wolf2pos;
    Vector3 wolf3pos;

    private AudioSource audioSource;

    [SerializeField] private AudioClip se1;
    [SerializeField] private AudioClip se2;
    [SerializeField] private AudioClip se3;

    
    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        WolfHP1 = 10;
        WolfHP2 = 13;
        WolfHP3 = 12;

        if(GameManager.Hellmode)
        {
            WolfHP1 = 20;
            WolfHP2 = 26;
            WolfHP3 = 24;
        }

        wolf1pos = new Vector3(Wolf1.transform.position.x, Wolf1.transform.position.y, Wolf1.transform.position.z);
        wolf2pos = new Vector3(Wolf2.transform.position.x, Wolf2.transform.position.y, Wolf2.transform.position.z);
        wolf3pos = new Vector3(Wolf3.transform.position.x, Wolf3.transform.position.y, Wolf3.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        wolf1pos = new Vector3(Wolf1.transform.position.x, Wolf1.transform.position.y, Wolf1.transform.position.z);
        wolf2pos = new Vector3(Wolf2.transform.position.x, Wolf2.transform.position.y, Wolf2.transform.position.z);
        wolf3pos = new Vector3(Wolf3.transform.position.x, Wolf3.transform.position.y, Wolf3.transform.position.z);
    }

    public void Damage1()
    {
        //wolf1Effect.hiteffect();
        
        ya1.SetActive(true);
        Invoke("hihyouzi1", 1.0f);
        
    }
    public void Damage2()
    {
        //wolf2Effect.hiteffect();
        
        ya2.SetActive(true);
        Invoke("hihyouzi2", 1.0f);
       
    }
    public void Damage3()
    {
        //wolf3Effect.hiteffect();
        
        ya3.SetActive(true);
        Invoke("hihyouzi3", 1.0f);
        
    }
    public void missSE()
    {
        audioSource.PlayOneShot(se1);
    }
    public void hitSE()
    {
        audioSource.PlayOneShot(se2);
    }
    public void damageSE()
    {
        audioSource.PlayOneShot(se3);
    }
    
    void hihyouzi1()
    {
        WolfHP1--;
        wolf1 = WolfHP1;
        ya1.SetActive(false);
        if (WolfHP1 == 0)
        {
            Wolf1.SetActive(false);
            WolfManager.wolfnum++;
        }
    }
    void hihyouzi2()
    {
        WolfHP2--;
        wolf2 = WolfHP2;
        ya2.SetActive(false);
        if (WolfHP2 == 0)
        {
            Wolf2.SetActive(false);
            WolfManager.wolfnum++;
        }
    }
    void hihyouzi3()
    {
        WolfHP3--;
        wolf3 = WolfHP3;
        ya3.SetActive(false);
        if (WolfHP3 == 0)
        {
            Wolf3.SetActive(false);
            WolfManager.wolfnum++;
        }
    }

}
