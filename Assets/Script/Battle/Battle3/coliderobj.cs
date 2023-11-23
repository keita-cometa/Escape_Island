using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coliderobj : MonoBehaviour
{
    public GameObject[] layerobj;
    public Renderer[] deerSprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    //ínñ Ç∆êGÇÍÇƒÇ¢ÇÈÇ∆Ç´ÇµÇ©Ç∆ÇµÇÈÇµÇëOñ Ç…
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {


            for (int i = 0; i < 2; i++)
            {
                deerSprite[i] = layerobj[i].GetComponent<Renderer>();
                if(i==0)               
                    deerSprite[i].sortingOrder = 4;
                else if(i==1)
                    deerSprite[i].sortingOrder = 3;
            }
            direction.obstacles = false;

        }
    }

    //ínñ Ç∆ó£ÇÍÇΩÇÁå„ñ Ç…
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    deerSprite[i].sortingOrder = 1;
                else if(i==1)
                    deerSprite[i].sortingOrder = 0;
            }
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
    
}
