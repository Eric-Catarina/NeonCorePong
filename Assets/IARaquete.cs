using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IARaquete : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private float timer;
    [SerializeField]
    private int direcao = 1;
    [SerializeField]
    private float delay = 1f;
    void FixedUpdate()
    {
        
       
        
        if (rb.position.y<-2.5)
        {
            direcao = direcao *-1;
        }

        if (rb.position.y>2.5)
        {
            direcao = direcao *-1;
        }
        rb.position +=new Vector2 (0,speed) * Time.deltaTime*direcao;
    }
}
