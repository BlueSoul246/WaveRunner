using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CNextLevel1 : MonoBehaviour
{
    //helps the wave move at different speeds for different levels
    int waveMover = 0;

    void Start()
    {
        //create a reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        //get name of this scene.
        string sceneName = currentScene.name;


        //level 1
        if (sceneName == "SandLevel1")
        {
            waveMover = 1;
        }

        //level 2
        else if (sceneName == "DirtLevel2")
        {
            waveMover = 2;
        }

        //level 3
        else if (sceneName == "CloudLevel3")
        {
            waveMover = 3;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //level 1 loads level 2
        if (waveMover == 1)
        {
            SceneManager.LoadScene("DirtLevel2");
        }

        //level 2 loads level 3
        else if (waveMover == 2)
        {
            SceneManager.LoadScene("CloudLevel3");
        }

        //level 3 loads win screen
        else if (waveMover == 3)
        {
            SceneManager.LoadScene("WinGame");
        }
    }

    void Update()
    {
        //level 1 loads level 2
        if (waveMover == 1)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                SceneManager.LoadScene("DirtLevel2");
            }   
        }

        //level 2 loads level 3
        else if (waveMover == 2)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                SceneManager.LoadScene("CloudLevel3");
            }
        }

        //level 3 loads win screen
        else if (waveMover == 3)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                SceneManager.LoadScene("WinGame");
            }
        }
    }
}
