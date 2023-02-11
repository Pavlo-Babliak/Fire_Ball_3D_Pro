using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public int Forces;
    public static int Button_fast_ball=1;
    void Start()
    {  
        GetComponent<Rigidbody>().AddForce((transform.forward * Forces)*Button_fast_ball, ForceMode.Impulse);
    }
    
}
