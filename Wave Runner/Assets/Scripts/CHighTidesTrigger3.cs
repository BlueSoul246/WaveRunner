using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHighTidesTrigger3 : MonoBehaviour
{
    void FixedUpdate()
    {
        this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.04f);
    }

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("CloudLevel3");
    }
}
