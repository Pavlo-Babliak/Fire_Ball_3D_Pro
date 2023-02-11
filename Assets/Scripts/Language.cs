using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Language : MonoBehaviour
{
    GameObject lang;
    public Sprite[] flag = new Sprite[3];
    public GameObject Flag;
    void Start()
    {
        lang = GameObject.Find("Language");
        if (!PlayerPrefs.HasKey("Language")) { PlayerPrefs.SetInt("Language", 0); }
        if (PlayerPrefs.GetInt("Language") == 1) {  lang.GetComponent<TextMeshProUGUI>().text = "ћова"; Flag.GetComponent<SpriteRenderer>().sprite = flag[1]; }
        if (PlayerPrefs.GetInt("Language") == 2) {  lang.GetComponent<TextMeshProUGUI>().text = "язык"; Flag.GetComponent<SpriteRenderer>().sprite = flag[2]; }
        if (PlayerPrefs.GetInt("Language") == 0) {  lang.GetComponent<TextMeshProUGUI>().text = "Language"; Flag.GetComponent<SpriteRenderer>().sprite = flag[0]; }
    }
    public void Select_language() 
    {
        if (PlayerPrefs.GetInt("Language") == 0) { PlayerPrefs.SetInt("Language", 1); lang.GetComponent<TextMeshProUGUI>().text = "ћова"; Flag.GetComponent<SpriteRenderer>().sprite = flag[1]; }
        else if (PlayerPrefs.GetInt("Language") == 1) { PlayerPrefs.SetInt("Language", 2); lang.GetComponent<TextMeshProUGUI>().text = "язык"; Flag.GetComponent<SpriteRenderer>().sprite = flag[2]; }
        else if (PlayerPrefs.GetInt("Language") == 2) { PlayerPrefs.SetInt("Language", 0); lang.GetComponent<TextMeshProUGUI>().text = "Language"; Flag.GetComponent<SpriteRenderer>().sprite = flag[0]; }
    }
}
