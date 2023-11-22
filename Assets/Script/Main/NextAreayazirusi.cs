using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAreayazirusi : MonoBehaviour
{
    public GameObject NextAreaButton;
    public GameObject yazirusi;

    // Start is called before the first frame update
    void Start()
    {
        NextAreaButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NextAreaButton.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        NextAreaButton.SetActive(false);
    }
}
