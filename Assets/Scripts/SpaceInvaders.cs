using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject invaderA;

    [SerializeField]
    GameObject invaderB;

    [SerializeField]
    int nInvaders = 7;

    [SerializeField]
    float xMin = -3f;
    void Awake()
    {
        float x = xMin;
        for(int i = 1; i<= nInvaders; i++)
        {
            GameObject newinvader = Instantiate(invaderA, transform);
            newinvader.transform.position = new Vector3( x, -0.5f, 0f);
            x += 1f; 
        }
        
    }

}
