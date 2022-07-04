using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private float forca =10f;
  
    void Start()
    {
       rb.AddForce(UnityEngine.Random.insideUnitCircle.normalized*forca,ForceMode2D.Impulse);
        
    }

    
    void Update()
    {
        
    }
}
