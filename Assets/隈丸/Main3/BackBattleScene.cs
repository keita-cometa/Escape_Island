using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBattleScene : MonoBehaviour
{
   public void SwitchScene()
   {
        SceneManager.LoadScene("BattleScene1", LoadSceneMode.Single);
   } 
}