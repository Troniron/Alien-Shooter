using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    private Uimanager ui;
    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
        ui = GameObject.Find("Canvas").GetComponent<Uimanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x> 11.8f)
        {
            Destroy(this.gameObject);
        }
   
        transform.Translate  (Vector3.right* speed * Time.deltaTime);
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag== "BigEnemy")
        {
            ui.Ehealth();
            Destroy(this.gameObject);
          
        }
        if (collision.gameObject.tag == "BigEnemy")
        {


        }
    }
    public void anotherMove()
    {
        ui.Ehealth();
     
        transform.Translate(Vector3.up * speed * Time.deltaTime);


    }
}
