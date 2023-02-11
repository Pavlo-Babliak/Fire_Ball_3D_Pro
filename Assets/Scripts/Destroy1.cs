using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy1 : MonoBehaviour
{
    public static bool Win;
    GameObject [] pereshcodu = new GameObject[2];
    GameObject Camera;
    GameObject Count_text;
    GameObject Object1;
    private void Start()
    {
        pereshcodu[0]= GameObject.Find("p1");
        pereshcodu[1] = GameObject.Find("p2");
        Camera = GameObject.Find("Main Camera");
        Camera.GetComponent<Win_Lose_Exit_trigger>().count++;
        Count_text = GameObject.Find("Count_text");
        Object1 = GameObject.Find("Object");
        gameObject.transform.position =new Vector3(0,gameObject.transform.position.y,0);
        Count_text.GetComponent<TextMeshPro>().text = System.Convert.ToString(Camera.GetComponent<Win_Lose_Exit_trigger>().count);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.rigidbody.name == "Ball(Clone)") 
        {
            Destroy(col.gameObject);
            Camera.GetComponent<Win_Lose_Exit_trigger>().count--;
            Count_text.GetComponent<TextMeshPro>().text = System.Convert.ToString(Camera.GetComponent<Win_Lose_Exit_trigger>().count);
            if (Spaawn_ball.Down == true) { gameObject.GetComponent<AudioSource>().pitch = gameObject.GetComponent<AudioSource>().pitch + Spaawn_ball.timer*4 ; }
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
            gameObject.GetComponent<Animator>().enabled = true;
            
            if (gameObject.name != "Crystal(Clone)") 
            {
                gameObject.GetComponent<AudioSource>().Play();
                Object1.transform.position = new Vector3(Object1.transform.position.x, Object1.transform.position.y - 0.6f, Object1.transform.position.z); 
            }
            gameObject.transform.position= new Vector3(gameObject.transform.position.x, 0.7f,gameObject.transform.position.z);
            if (Camera.GetComponent<Win_Lose_Exit_trigger>().count <= 0) 
            { 
                StartCoroutine(Win1());
                if (pereshcodu[0]) { pereshcodu[0].active = false; }
                if (pereshcodu[1]) { pereshcodu[1].active = false; }    
            }
        }
    }
    IEnumerator Win1() 
    {
        yield return new WaitForSeconds(1.5f);
        Win = true;
    }
    public void Particle() { gameObject.GetComponent<ParticleSystem>().Play(); gameObject.GetComponent<AudioSource>().Play(); }
    public void Stop_anim() 
    {
        Destroy(gameObject);
    }
}
