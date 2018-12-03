using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHighTides : MonoBehaviour
{
    //helps the wave move at different speeds for different levels
    int waveMover = 0;

    void Start()
    {
        //create a reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        //get name of this scene.
        string sceneName = currentScene.name;

        
        //speed slow
        if(sceneName == "SandLevel1")
        {
            waveMover = 1; 
        }

        //speed medium
        else if(sceneName == "DirtLevel2")
        {
            waveMover = 2;
        }

        //speed fast
        else if(sceneName == "CloudLevel3")
        {
            waveMover = 3;
        }
    }

    void FixedUpdate()
    {
        //speed slow
        if (waveMover == 1)
        {
            this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.028f);
        }

        //speed medium
        else if (waveMover == 2)
        {
            this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.035f);
        }

        //speed fast
        else if (waveMover == 3)
        {
            this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.04f);
        }
    }

}
