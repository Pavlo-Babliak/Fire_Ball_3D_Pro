using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_menu : MonoBehaviour
{
    public GameObject exit;

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                exit.active = true;
            }
        }
    }
}
