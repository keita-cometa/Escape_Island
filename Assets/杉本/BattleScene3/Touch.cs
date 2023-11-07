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
        StartCoroutine(Indication());
        Click = true;

    }
    IEnumerator Indication()
    {
        yield return new WaitForSeconds(indication_time);
        clickGameObject.transform.position = target.transform.position;
        clickGameObject.SetActive(true);
        Click = false;

    }

    
    // Update is called once per frame
    void Update()
    {
        
    }    
}
