using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHighTides : MonoBehaviour
{
    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        //bool waveMover = true;

        if(sceneName == "SandLevel1")
        {
            while(waveMover == true)
            {
                this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.02f);
            }    
        }

        else if(sceneName == "DirtLevel2")
        {
            while (waveMover == true)
            {
                this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.03f);
            }
        }

        else if(sceneName == "CloudLevel3")
        {
            while (waveMover == true)
            {
                this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.04f);
            }
        }
    }

}
