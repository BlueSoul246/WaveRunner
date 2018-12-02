using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CNextLevel1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("DirtLevel2");
    }

}
