using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
public class movepoint : MonoBehaviour
{
    public Transform movepointA;
    public Transform movepointB;
    public Transform target;
    private float time;
    private float vecX;
    private float vecY;
    public static Vector2 beforpos;
    public static Vector2 afterpos;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }
    // Update is called once per frame
    void Update()
    {
        beforpos = transform.position;
        MovePos();

        if(Touch.click==true)
        {
            MovePos();
        }
    }
    public Vector2 MovePos()
    {
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            vecX = Random.Range(movepointA.position.x - transform.localScale.x, movepointB.position.x);
            vecY = Random.Range(movepointA.position.y, movepointB.position.y);

            transform.position = new Vector2(vecX, vecY);
            afterpos = transform.position;
            if (Touch.click == true || transform.position==target.transform.position)
            {
                time = 1.0f;
            }
            else
            {
                time = 1.5f;
            }
        }
        

        return transform.position;
    }
}

