using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoShield : MonoBehaviour
{
   // private float Max, Min,speed;
 //   private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
     //   Max = 11.8f;
       // Min = -11.63f;
        //speed = 1f;
        //rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 8 * Time.deltaTime);
        if(transform.position.x< -11.5f)
        {
            Destroy(this.gameObject);
        }
       // SatLimit();
       // transform.Translate(Vector3.right * speed * Time.deltaTime);
               
    }
  /*  public void SatLimit()
    {
        if (transform.position.x >= Max)
        {
            transform.position = new Vector3(Min, transform.position.y, 0f);
        }
        else if (transform.position.x <= Min)
        {
            transform.position = new Vector3(Max, transform.position.y, 0f);
        }
    }*/
}
