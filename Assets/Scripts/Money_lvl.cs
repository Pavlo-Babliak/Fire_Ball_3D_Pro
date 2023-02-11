using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money_lvl : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + Application.loadedLevel);
        GetComponent<TextMeshProUGUI>().text ="+"+ System.Convert.ToString(Application.loadedLevel);
    }

}
