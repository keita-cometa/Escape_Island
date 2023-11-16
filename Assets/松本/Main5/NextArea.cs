using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextArea : MonoBehaviour
{
    public GameObject NextButton;

    // Start is called before the first frame update
    void Start()
    {
        NextButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NextButton.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NextButton.SetActive(false);
    }
}
