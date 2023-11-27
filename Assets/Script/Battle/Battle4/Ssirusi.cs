using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ssirusi : MonoBehaviour
{
    public GameObject clickedGameObject;
    public static bool sign=false;
    public static int Sclearnum=10;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && StartC.onclick)
        {

            //clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hitSprite == true)
            {
                Debug.Log("sprig");
                clickedGameObject = hitSprite.transform.gameObject;
                Debug.Log(clickedGameObject.tag);
                if (clickedGameObject.tag == "sirusi")
                {
                    clickedGameObject.SetActive(false);
                    sign = true;
                    Sclearnum--;
                    Debug.Log("hit");
                }
                else
                {
                    audioSource.PlayOneShot(se);
                }
            }
            else
            {
                audioSource.PlayOneShot(se);
            }
        }
    }
}
