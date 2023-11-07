using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, mousePos,
         -speed * Time.fixedDeltaTime);
    }
}
