using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class ButtonKey : MonoBehaviour
{
    [SerializeField] KeyCode Enter_key = default;
    Button _button = default;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Enter_key))
        {
            _button.onClick.Invoke();
        }
    }
}
