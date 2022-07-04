using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
   private Rigidbody2D rb;
   [SerializeField]
   private float speed = 10; 
   [SerializeField]
   private Transform limiteCima;
   [SerializeField]
   private Transform limiteBaixo;
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertical =  Input.GetAxis("Vertical");
        rb.position += new Vector2(0, vertical *Time.fixedDeltaTime * speed);
        if (rb.position.y> limiteCima.position.y){
            rb.position = limiteCima.position;
        }
        else if (rb.position.y < limiteBaixo.position.y){
            rb.position = limiteBaixo.position;
        }
    }
}
