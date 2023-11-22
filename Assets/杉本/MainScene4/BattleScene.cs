using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScene : MonoBehaviour
{
    public string sceneName;//ì«Ç›çûÇﬁÉVÅ[Éìñº

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Invoke("battle", 4.0f);
        PlayerController.isMoving = true;
        enemymove.isMoving = true;
    }

    void battle()
    {
        SceneManager.LoadScene(sceneName);
        ChangeScene1.batnum = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
