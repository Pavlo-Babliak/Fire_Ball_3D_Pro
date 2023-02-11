using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Setting : MonoBehaviour
{
    public GameObject Setting_list;
    public GameObject Music_img;
    public GameObject Setting_text;
    public GameObject Text;
    void Start()
    {
        if (!PlayerPrefs.HasKey("Music")) { PlayerPrefs.SetInt("Music", 1); }
        if (PlayerPrefs.GetInt("Music") == 1) { Music_img.GetComponent<Image>().color = new Color32(0, 255, 0, 255); GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = true; }
        else if (PlayerPrefs.GetInt("Music") == 0) { Music_img.GetComponent<Image>().color = new Color32(255, 0, 0, 255); GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false; }
    }

    public void Music() 
    {
        if (PlayerPrefs.GetInt("Music") == 0) { Music_img.GetComponent<Image>().color = new Color32(0, 255, 0, 255); PlayerPrefs.SetInt("Music", 1); GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = true; }
        else if (PlayerPrefs.GetInt("Music") == 1) { Music_img.GetComponent<Image>().color = new Color32(255, 0, 0, 255); PlayerPrefs.SetInt("Music", 0); GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false; }
    }
    public void Restart() 
    {
        if (PlayerPrefs.GetInt("Language") == 0) { Text.GetComponent<TextMeshProUGUI>().text = "Restart? (All progress will be deleted)"; }
        if (PlayerPrefs.GetInt("Language") == 1) { Text.GetComponent<TextMeshProUGUI>().text = "Розпочати заново? (Увесь прогрес буде видалено)"; }
        if (PlayerPrefs.GetInt("Language") == 1) { Text.GetComponent<TextMeshProUGUI>().text = "Начать заново?  (Весь прогресс будет удален)"; }
        Setting_text.active = true;
    }
    public void Restrt_yes() { PlayerPrefs.DeleteKey("LAST_LVL"); PlayerPrefs.DeleteKey("Money_all"); PlayerPrefs.DeleteKey("Money"); PlayerPrefs.SetInt("Money", 0); PlayerPrefs.SetInt("LAST_LVL", 0); PlayerPrefs.SetInt("Money_all", 0); Application.LoadLevel(0); }
    public void Restrt_no() { Setting_text.active = false; }

    public void Open_setting_list() 
    {
        if (Setting_list.active == true) { Setting_list.active = false; }
        else Setting_list.active = true;
    }
}
