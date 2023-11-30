using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHPmanager : MonoBehaviour
{
    public GameObject Wolf1;
    public GameObject Wolf2;
    public GameObject Wolf3;

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
        WolfHP1--;
        wolf1 = WolfHP1;
        if (WolfHP1 == 0)
        {
            Wolf1.SetActive(false);
            WolfManager.wolfnum++;
        }
    }
    public void Damage2()
    {
        //wolf2Effect.hiteffect();
        WolfHP2--;
        wolf2 = WolfHP2;
        if (WolfHP2 == 0)
        {
            Wolf2.SetActive(false);
            WolfManager.wolfnum++;
        }
    }
    public void Damage3()
    {
        //wolf3Effect.hiteffect();
        WolfHP3--;
        wolf3 = WolfHP3;
        if (WolfHP3 == 0)
        {
            Wolf3.SetActive(false);
            WolfManager.wolfnum++;
        }
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
}
