using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]
    GameObject Fire;

    [SerializeField]
    GameObject nozzle;

    [SerializeField]
    float velocidade = 5f;

    float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        minX = Camera.main.ViewportToWorldPoint(Vector2.zero).x + 0.5f;
        maxX = Camera.main.ViewportToWorldPoint(Vector2.one).x - 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Fire, transform.position, transform.rotation);
        }

        MoveShip();

        void MoveShip()
        {
            float hMov = Input.GetAxis("Horizontal");
            transform.position += hMov * velocidade * Vector3.right * Time.deltaTime;

            Vector3 position = transform.position;
            position.x = Mathf.Clamp(position.x, minX, maxX);
            transform.position = position;
        }
        
    }
}
