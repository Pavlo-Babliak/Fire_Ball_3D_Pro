using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class All_money : MonoBehaviour
{
    GameObject money;
    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 120;
    }
    void Start()
    {
        if (Application.loadedLevel == 0) { RenderSettings.fog = false; }
        else { RenderSettings.fog = true; }
        money = GameObject.Find("Money_all");
        
        if (PlayerPrefs.GetInt("Music") == 0) { GetComponent<AudioSource>().enabled = false; }
        else if (PlayerPrefs.GetInt("Music") == 1) { GetComponent<AudioSource>().enabled = true; }

        if (PlayerPrefs.HasKey("Money"))
        {
            
            if (Application.loadedLevel == 0) { money.GetComponent<TextMeshProUGUI>().text = System.Convert.ToString(PlayerPrefs.GetInt("Money")); }
            else { money.GetComponent<TextMeshPro>().text = System.Convert.ToString(PlayerPrefs.GetInt("Money")); }
        }
        else
        {
            PlayerPrefs.SetInt("Money", 0);
            if (Application.loadedLevel == 0) { money.GetComponent<TextMeshProUGUI>().text = System.Convert.ToString(PlayerPrefs.GetInt("Money")); }
            else { money.GetComponent<TextMeshPro>().text = System.Convert.ToString(PlayerPrefs.GetInt("Money")); }
        }
    }
}
