using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtan : MonoBehaviour
{ 
    public void SwitchScene()
    {
        if (ChangeScene1.batnum == 1)//–Ø
            SceneManager.LoadScene("MainScene1");
        if (ChangeScene1.batnum == 3)//Ž­
            SceneManager.LoadScene("MainScene3");
        if (ChangeScene1.batnum == 4)//ƒCƒmƒVƒV
            SceneManager.LoadScene("MainScene4");
        if (ChangeScene1.batnum == 5)//ŽÖ
            SceneManager.LoadScene("MainScene4");
        if (ChangeScene1.batnum == 6)//˜T
            SceneManager.LoadScene("MainScene5");
        if (ChangeScene1.batnum == 7)//–Ø‹­‰»”Å
            SceneManager.LoadScene("MainScene3");
    }
}
   

