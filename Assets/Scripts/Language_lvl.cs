using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Language_lvl : MonoBehaviour
{
    
    void Start()
    {
        if (PlayerPrefs.GetInt("Language") == 0) 
        {
            if (gameObject.name == "Text_win") { GetComponent<TextMeshProUGUI>().text = "Victory"; }
            if (gameObject.name == "Text_Menu") { GetComponent<TextMeshProUGUI>().text = "Menu"; }
            if (gameObject.name == "Text_Next") { GetComponent<TextMeshProUGUI>().text = "Next"; }
            if (gameObject.name == "Text_Lose") { GetComponent<TextMeshProUGUI>().text = "Defeat"; }
            if (gameObject.name == "Text_Return") { GetComponent<TextMeshProUGUI>().text = "Return"; }
            if (gameObject.name == "Text_Menu_lose") { GetComponent<TextMeshProUGUI>().text = "Menu"; }
            if (gameObject.name == "Text_Exit") { GetComponent<TextMeshProUGUI>().text = "Exit?"; }
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            if (gameObject.name == "Text_win") { GetComponent<TextMeshProUGUI>().text = "��������"; }
            if (gameObject.name == "Text_Menu") { GetComponent<TextMeshProUGUI>().text = "����"; }
            if (gameObject.name == "Text_Next") { GetComponent<TextMeshProUGUI>().text = "���������"; }
            if (gameObject.name == "Text_Lose") { GetComponent<TextMeshProUGUI>().text = "�������"; }
            if (gameObject.name == "Text_Return") { GetComponent<TextMeshProUGUI>().text = "���������"; }
            if (gameObject.name == "Text_Menu_lose") { GetComponent<TextMeshProUGUI>().text = "����"; }
            if (gameObject.name == "Text_Exit") { GetComponent<TextMeshProUGUI>().text = "�����?"; }
        }
        if (PlayerPrefs.GetInt("Language") == 2)
        {
            if (gameObject.name == "Text_win") { GetComponent<TextMeshProUGUI>().text = "������"; }
            if (gameObject.name == "Text_Menu") { GetComponent<TextMeshProUGUI>().text = "����"; }
            if (gameObject.name == "Text_Next") { GetComponent<TextMeshProUGUI>().text = "���������"; }
            if (gameObject.name == "Text_Lose") { GetComponent<TextMeshProUGUI>().text = "���������"; }
            if (gameObject.name == "Text_Return") { GetComponent<TextMeshProUGUI>().text = "���������"; }
            if (gameObject.name == "Text_Menu_lose") { GetComponent<TextMeshProUGUI>().text = "����"; }
            if (gameObject.name == "Text_Exit") { GetComponent<TextMeshProUGUI>().text = "�����?"; }
        }
    }

}
