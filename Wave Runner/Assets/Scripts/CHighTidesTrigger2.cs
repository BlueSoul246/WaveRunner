using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHighTidesTrigger2 : MonoBehaviour
{
    void FixedUpdate()
    {
        this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.03f);
    }

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("DirtLevel2");
    }
}
