using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoodMain4 : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("MainScene4", LoadSceneMode.Single);
    }
}
