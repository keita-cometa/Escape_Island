using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtan : MonoBehaviour
{ 
    public void SwitchScene()
    {
        if (ChangeScene1.batnum == 1)//ñÿ
            SceneManager.LoadScene("MainScene1");
        if (ChangeScene1.batnum == 3)//é≠
            SceneManager.LoadScene("MainScene3");
        if (ChangeScene1.batnum == 4)//ÉCÉmÉVÉV
            SceneManager.LoadScene("MainScene4");
        if (ChangeScene1.batnum == 5)//é÷
            SceneManager.LoadScene("MainScene4");
        if (ChangeScene1.batnum == 6)//òT
            SceneManager.LoadScene("MainScene5");
    }
}
   

