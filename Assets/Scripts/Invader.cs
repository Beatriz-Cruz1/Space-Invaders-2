using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    [SerializeField]
    GameObject Fire;

    [SerializeField]
    float cadencia = 1.5f;

    float tempoQuePassou = 0f;

    private void Update()
    {
        tempoQuePassou += Time.deltaTime;
        if(tempoQuePassou >= cadencia)
        {
           Instantiate(fire)
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
