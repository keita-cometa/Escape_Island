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

    private AudioSource audioSource;
    [SerializeField] private AudioClip se1;
    [SerializeField] private AudioClip se2;
    [SerializeField] private AudioClip se3;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
        
    }

    public void Damage1()
    {
        WolfHP1--;
        if (WolfHP1 == 0)
        {
            Wolf1.SetActive(false);
            WolfManager.wolfnum++;
        }
    }
    public void Damage2()
    {
        WolfHP2--;
        if (WolfHP2 == 0)
        {
            Wolf2.SetActive(false);
            WolfManager.wolfnum++;
        }
    }
    public void Damage3()
    {
        WolfHP3--;
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
