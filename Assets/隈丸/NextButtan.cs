using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtan : MonoBehaviour
{

        public void SwitchScene()
        {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
}
   

