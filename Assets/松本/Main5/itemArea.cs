using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemArea : MonoBehaviour
{
    public GameObject SearchButton;

    // Start is called before the first frame update
    void Start()
    {
        SearchButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(!PlayerController.isMoving)
            SearchButton.SetActive(true);
        if(PlayerController.isMoving)
            SearchButton.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SearchButton.SetActive(false);
    }
}
