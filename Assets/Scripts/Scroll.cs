using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scroll : MonoBehaviour
{
    Scrollbar scroll;
    void Start()
    {
        scroll = GameObject.Find("Scrollbar Vertical").GetComponent<Scrollbar>();
        scroll.value = 0.01f*PlayerPrefs.GetInt("LAST_LVL");
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, -scroll.value * 410);
    }
}
