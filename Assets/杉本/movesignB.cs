using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesignB : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
