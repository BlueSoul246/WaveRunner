using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHighTides : MonoBehaviour
{
	void FixedUpdate ()
    {
        this.transform.position = new Vector2(0.0f, this.transform.position.y + 0.02f);
    }
}
