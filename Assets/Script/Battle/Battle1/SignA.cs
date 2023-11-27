using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignA : MonoBehaviour
{
    public static bool ClickSignA;
    public GameObject TouchSignA;

    public SignASE signASE;

    // Start is called before the first frame update
    void Start()
    {
        ClickSignA = false;
    }

    //public void Click()
    //{
        
    //}
    // Update is called once per frame
    void Update()
    {
        if (StartC.onclick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
                if (hitSprite == true)
                {
                    TouchSignA = hitSprite.transform.gameObject;
                    if (TouchSignA.tag == "signA")
                    {
                        ClickSignA = true;
                        TouchSignA.SetActive(false);
                        signASE.SE();
                    }
                }
            }
        }
    }
}
