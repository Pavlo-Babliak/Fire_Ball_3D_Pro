using TMPro;
using UnityEngine;

public class Num_lvl_game : MonoBehaviour
{

    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = System.Convert.ToString(Application.loadedLevel);
    }

    public void Stop_anim() { GetComponent<Animator>().enabled = false; }
}
