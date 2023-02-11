using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_circle : MonoBehaviour
{
    public GameObject[] Circle = new GameObject[4];
    public GameObject Crystal;
    public int count;
    public GameObject Plan;
    public float Povorot;
    void Start()
    {

        for (int i = 0; i < count; i++)
        {
            if (i==count-1) 
            {
                Instantiate(Crystal, new Vector3(-0.82f, 0.7f + i * Circle[0].transform.lossyScale.y, -0.43f), Quaternion.Euler(-90, i * Povorot, 0)).transform.parent = Plan.transform;
            }
            else {
                if (i % 4 == 0)
                {
                    Instantiate(Circle[0], new Vector3(-0.82f, 0.7f + i * Circle[0].transform.lossyScale.y, -0.43f), Quaternion.EulerAngles(0, i * Povorot, 0)).transform.parent = Plan.transform;
                }
                else if (i % 3 == 0)
                {
                    Instantiate(Circle[1], new Vector3(-0.82f, 0.7f + i * Circle[1].transform.lossyScale.y, -0.43f), Quaternion.EulerAngles(0, i * Povorot, 0)).transform.parent = Plan.transform;
                }
                else if (i % 2 == 0)
                {
                    Instantiate(Circle[2], new Vector3(-0.82f, 0.7f + i * Circle[2].transform.lossyScale.y, -0.43f), Quaternion.EulerAngles(0, i * Povorot, 0)).transform.parent = Plan.transform;
                }
                else
                {
                    Instantiate(Circle[3], new Vector3(-0.82f, 0.7f + i * Circle[3].transform.lossyScale.y, -0.43f), Quaternion.EulerAngles(0, i * Povorot, 0)).transform.parent = Plan.transform;
                }
            }
        }


    }

}
