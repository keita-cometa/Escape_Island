using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    private static bool Loaded { get; set; }

    private void Awake()
    {
        if (Loaded) return;

        Loaded = true;
        SceneManager.LoadScene("ManagerScene", LoadSceneMode.Additive);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
