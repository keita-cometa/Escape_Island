using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getSE : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    public GameObject clickGameObject;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitSprite == true)
            {
                clickGameObject = hitSprite.transform.gameObject;
                if (clickGameObject.tag == "signB")
                {
                    audioSource.PlayOneShot(se);
                    Debug.Log("SE");
                }
            }
        }
    }
}
