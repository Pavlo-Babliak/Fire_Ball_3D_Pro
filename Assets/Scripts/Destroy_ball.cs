using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Destroy_ball : MonoBehaviour
{
    public static bool lose;
    GameObject glass;
    ParticleSystem Gp;
    public static bool lose1;
    GameObject ball;
    private void Start()
    {
        lose = false;
        glass = GameObject.Find("Glass");
        Gp= GameObject.Find("G_P").GetComponent<ParticleSystem>();
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.rigidbody.name == "Ball(Clone)")
        {
            if (gameObject.name == "Lose_trig")
            {
                lose1 = true;
                glass.GetComponent<Image>().enabled = true;
                glass.GetComponent<AudioSource>().Play();
                Gp.Play();
                StartCoroutine(lose_lvl());
            }
            else if (gameObject.name != "Destoy")
            {
                col.rigidbody.isKinematic = true;
                col.rigidbody.transform.position = new Vector3(0, 0.7866421f, -6.5f);
                col.rigidbody.isKinematic = false;
                col.rigidbody.GetComponent<Rigidbody>().AddForce(new Vector3(0, 32.5f, -30) * 5, ForceMode.Impulse);
                gameObject.GetComponent<AudioSource>().Play();
                ball = col.rigidbody.gameObject;
                StartCoroutine(lose_lvl1());
                
            }
            else { Destroy(col.rigidbody.gameObject); }
        }
    }
    IEnumerator lose_lvl() 
    {
        yield return new WaitForSeconds(1);
        Handheld.Vibrate();
        lose = true;
    }
    IEnumerator lose_lvl1()
    {
        ball.GetComponent<SphereCollider>().isTrigger = true;
        yield return new WaitForSeconds(0.2f);
        ball.GetComponent<SphereCollider>().isTrigger = false;
        
    }
}
