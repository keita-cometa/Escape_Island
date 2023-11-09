using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    [SerializeField] GameObject clickGameObject;
    public GameObject target;
    public float indication_time;
    public static bool Click;

    // Start is called before the first frame update
    void Start()
    {
        clickGameObject.SetActive(true);
        Click = false;

    }

    public void Onclick()
    {
        Debug.Log("cilck");

        clickGameObject.SetActive(false);
        Click = true;
        StartCoroutine(Indication());

    }
    IEnumerator Indication()
    {
        yield return new WaitForSeconds(indication_time);

        clickGameObject.SetActive(true);
        Click = false;

        clickGameObject.transform.position = target.transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        if (direction.obstacles == false && Click == false)
        {
            clickGameObject.SetActive(true);
        }
        else if (direction.obstacles == true || Click == true)
        {
            clickGameObject.SetActive(false);
        }
    }    
}
