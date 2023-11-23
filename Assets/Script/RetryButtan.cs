using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtan : MonoBehaviour
{

    public void SwitchScene()
    {
        if (ChangeScene1.batnum == 1)
            SceneManager.LoadScene("BattleScene1");
        if (ChangeScene1.batnum == 3)
            SceneManager.LoadScene("BattleScene3");
        if (ChangeScene1.batnum == 4)
            SceneManager.LoadScene("InosisiBattle");
        if (ChangeScene1.batnum == 5)
            SceneManager.LoadScene("SnakeBattle");
        if (ChangeScene1.batnum == 6)
            SceneManager.LoadScene("BossBattleScene5");
    }
}
