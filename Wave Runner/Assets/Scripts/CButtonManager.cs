using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CButtonManager : MonoBehaviour
{
    /*
    public Button startGameButton;

    public Camera cam;

    private void Start()
    {
        startGameButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //access the camera
        //Camera cam = gameObject.GetComponent<Camera>();
        cam = Camera.main;

        //move cam to show controls
        cam.transform.position = new Vector3(-1100, 1, -424.13f);

        startGameButton.gameObject.SetActive(false);
    }
    */


    public void StartGameButton(string newGame)
    {
        SceneManager.LoadScene(newGame);
    }
}
