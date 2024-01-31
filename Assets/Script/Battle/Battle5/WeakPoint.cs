using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoint : MonoBehaviour
{
    public GameObject weakPoint;//�E�B�[�N�|�C���g�I�u�W�F�N�g
    public static int WHP;//�I�I�J�~��HP�ϐ������l10

    public static bool pointFlg = true;//�|�C���g���A�N�e�B�u���ǂ�������p

    public static bool hit1=false;
    public static bool hit2=false;
    public static bool hit3=false;

    private AudioSource audioSource;
    //public float activetime;//�A�N�e�B�u�ɂȂ�܂ł̎���

    public WolfHPmanager wolfManager;

    public Wolf1effect wolf1Effect;
    public Wolf2effect wolf2Effect;
    public Wolf3effect wolf3Effect;

    [SerializeField] GameObject hitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
      if (Input.GetMouseButtonDown(0)&&StartC.onclick)
        {
            //�N���b�N�����Ƃ�Ray���΂�
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitSprite == true)
            {
                //��΂�����ɃQ�[���^�O�iweak�j���Ȃ������ׂ�
                weakPoint = hitSprite.transform.gameObject;
                Debug.Log("Ray");
                if (weakPoint.tag == "weak1")
                {
                    hit1 = true;
                    wolf1Effect.hiteffect();
                    Debug.Log("hit");
                    wolfManager.Damage1();
                    //�q�b�g�����Ƃ��E�B�[�N�|�C���g���ꎞ�I�ɉB��
                    weakPoint.SetActive(false);
                    wolfManager.hitSE();
                    //audioSource.PlayOneShot(se1);
                }
                else if (weakPoint.tag == "weak2")
                {
                    hit2 = true;
                    wolf2Effect.hiteffect();
                    Debug.Log("hit");
                    wolfManager.Damage2();
                    //�q�b�g�����Ƃ��E�B�[�N�|�C���g���ꎞ�I�ɉB��
                    weakPoint.SetActive(false);
                    wolfManager.hitSE();
                    //audioSource.PlayOneShot(se1);
                }
                else if (weakPoint.tag == "weak3")
                {
                    hit3 = true;
                    wolf3Effect.hiteffect();
                    Debug.Log("hit");
                    wolfManager.Damage3();
                    //�q�b�g�����Ƃ��E�B�[�N�|�C���g���ꎞ�I�ɉB��
                    weakPoint.SetActive(false);
                    wolfManager.hitSE();
                    //audioSource.PlayOneShot(se1);
                }
                
            }
            else
            {
                //audioSource.PlayOneShot(se2);
                wolfManager.missSE();
            }
        }
        
     
    }
}