using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Spaawn_ball : MonoBehaviour
{
    public GameObject Ball;
    private bool isDown;
    public static bool Down;
    public static float timer;
    public GameObject Canon;
    bool corotina;
    GameObject Button_fast;

    private void Start()
    {
        Button_fast = GameObject.Find("Button_fast_ball");
        if (PlayerPrefs.GetInt("Money") < 5) { Button_fast.active = false; }
    }

    public void OnPointerDown()
    {
        if (corotina == false)
        {
            isDown = true;
            StartCoroutine(Spawn_ball());
            Down = true;
            Canon.GetComponent<Animator>().enabled = true;
        }
    }

    public void OnPointerUp()
    {
        
        isDown = false;
        Canon.GetComponent<Animator>().enabled = false;
        Canon.GetComponent<Animator>().Rebind();
        StartCoroutine(Stop_timer());
    }
    IEnumerator Stop_timer() 
    {
        yield return new WaitForSeconds(0.5f);
        timer = 0;
        Down = false;
    }
    IEnumerator Spawn_ball()
    {
            while (isDown == true)
            {
                timer += Time.deltaTime;
                Instantiate(Ball, new Vector3(0, 0.87f, -11), Quaternion.identity);
                corotina = true;
                yield return new WaitForSeconds(0.06f);
                if (Destroy_ball.lose1 == true) { Canon.GetComponent<Animator>().enabled = false; Canon.GetComponent<Animator>().Rebind(); break;  }
            }
            corotina = false;
    }
    public void fast() 
    {
        if (PlayerPrefs.GetInt("Money") >= 5) { PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 5); StartCoroutine(Fast()); }
        else Button_fast.active = false;
    }
    IEnumerator Fast()
    {
        GameObject.Find("Money_all").GetComponent<TextMeshPro>().text = System.Convert.ToString(PlayerPrefs.GetInt("Money"));
        Button_fast.active = false;
        Impulse.Button_fast_ball = 2;
        yield return new WaitForSeconds(5);
        Impulse.Button_fast_ball = 1;
        Button_fast.active = true;
        if (PlayerPrefs.GetInt("Money") < 5) { Button_fast.active = false; }
    }


}

