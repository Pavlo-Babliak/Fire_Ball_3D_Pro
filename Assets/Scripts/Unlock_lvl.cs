using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_lvl : MonoBehaviour
{
    GameObject f1, f2, circle;
    void Start()
    {
        f1 = transform.Find("Flag").transform.Find("node_id52").gameObject;
        f2 = transform.Find("Flag").transform.Find("node_id54").gameObject;
        circle = transform.Find("Circle").gameObject;
        if (!PlayerPrefs.HasKey("LAST_LVL")) { PlayerPrefs.SetInt("LAST_LVL", 0); }
        if (PlayerPrefs.GetInt("LAST_LVL") >=System.Convert.ToInt32(gameObject.name)) 
        {
            transform.Find("Obj").gameObject.active=false;
            f1.GetComponent<MeshRenderer>().enabled = true;
            f2.GetComponent<MeshRenderer>().enabled = true;
        }
        if (PlayerPrefs.GetInt("LAST_LVL")+1== System.Convert.ToInt32(gameObject.name))
        {
            circle.GetComponent<SpriteRenderer>().color = new Color32(255,0,0,255);
            circle.GetComponent<Animator>().enabled = true;
        }
    }

}
