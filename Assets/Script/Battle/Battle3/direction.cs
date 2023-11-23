using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    public GameObject target;//ƒ‰ƒ“ƒ_ƒ€‚ÈêŠ
    public static bool obstacles;

    // Start is called before the first frame update
    void Start()
    {
        obstacles = false;
    
    }

    //áŠQ•¨‚ÆG‚ê‚Ä‚¢‚½‚ç
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Obstacles"))
        {        
            obstacles = true;
        }
        
    }

    //—£‚ê‚½‚ç
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Obstacles"))
        {
            obstacles = false;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < target.transform.position.x)             //©•ª‚ÌˆÊ’u‚ªƒ‰ƒ“ƒ_ƒ€‚ÌˆÚ“®êŠ‚æ‚è‰E‘¤‚È‚ç
        {

            transform.localScale = new Vector2(-1, 1);  //‰æ‘œ”½“]
        }
        else if (transform.position.x == target.transform.position.x)        //ˆÚ“®êŠ‚É‚Â‚¢‚½‚ç
        {
            transform.localScale = transform.localScale;//‰æ‘œ‚Í‚»‚Ì‚Ü‚Ü
        }
        else                                                                //¶‘¤‚È‚ç
        {
            transform.localScale = new Vector2(1, 1);   //Œ³‚Ì‰æ‘œ
        }
    }
}
