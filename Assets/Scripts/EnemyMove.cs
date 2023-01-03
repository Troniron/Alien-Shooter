using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float speed;
    private Animator am;
    private Uimanager ui;
    private PlayerControll playerControll;
    // Start is called before the first frame update
    void Start()
    {
        speed = 17f;
        am = GetComponent<Animator>();
        ui = GameObject.Find("Canvas").GetComponent<Uimanager>();
         playerControll = GameObject.Find("Player").GetComponent<PlayerControll>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< -11.68f)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    
    {
       
        if (collision.gameObject.CompareTag("Bullet"))
        {
           
            Destroy(this.gameObject,0.5f);
            am.SetBool("Expo1", true);
            ui.count();
        
            this.enabled = false;
            playerControll.enemysounds();


        }
    if (collision.gameObject.CompareTag( "Player"))
        {
           
            Destroy(this.gameObject,0.5f);
            am.SetBool("Expo1", true);
            this.enabled = false;
            playerControll.enemysounds();
        }
   else if (collision.gameObject.CompareTag ( "Pshield"))
        {
           
           
            ui.count();
            Destroy(this.gameObject,0.5f);
            am.SetBool("Expo1", true);
            this.enabled = false;
            playerControll.enemysounds();
        }
        if (collision.gameObject.CompareTag( "CoverShield"))
        {
            am.SetBool("Expo1", true);
            Destroy(this.gameObject,0.5f);
            this.GetComponent<BoxCollider2D>().enabled = false;
            this.enabled = false;
            playerControll.enemysounds();

        }
    }

    
}
