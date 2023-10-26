using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtan : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("BatleScene", LoadSceneMode.Single);
    }
}
