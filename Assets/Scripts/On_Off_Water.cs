using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off_Water : MonoBehaviour
{
    GameObject ocean;
    void Start()
    {
        ocean = GameObject.Find("Ocean");
    }
    public void On_Off()
    {
        if (ocean.active == true) { ocean.active = false; } else ocean.active = true;
    }
}
