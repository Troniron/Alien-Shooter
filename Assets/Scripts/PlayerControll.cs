using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControll : MonoBehaviour
{
    public static PlayerControll Instance;
    [SerializeField]
    private float speed;
        private int Currenthealth,Maxhealth=100;
    private Rigidbody2D rb;
    private float Max, Min, Max2, Min2; 
 
    private Uimanager ui;
    [SerializeField]
    private Animator Anim;
 
    public GameObject  Thruster, fire,Gameover,Pause,Transprent,Shield,CoverShield,Scores,Health;
    private EnemySpawning ES;
    public AudioSource source;
    public AudioClip gameover,Powerup;
   
    public AudioClip enemyclip;
   
    [SerializeField]
    private SliderScript slider;
 
    private BulletUnlimitedspwan Bunlimit;
    [SerializeField]
    private Transform PlayerTrans;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
       
        Currenthealth = Maxhealth;
        slider.maxhealth(Maxhealth);

        Max = 7.02f;
        Min = -5.76f;
        Max2 = 7.68f;
        Min2 = -5.71f;
       
      
   
        ES = GameObject.Find("EnemySpawn").GetComponent<EnemySpawning>();
        Bunlimit = GameObject.Find("Bulletunlimited").GetComponent<BulletUnlimitedspwan>();
        rb = GetComponent<Rigidbody2D>();
      
        ui = GameObject.Find("Canvas").GetComponent<Uimanager>();
        singledon();
      
    }
    public void singledon()
    {
        if (Instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            Instance = this;
          
        }

    }
   
    // Update is called once per frame
    private void Update()
    {
        holdmove();
    }
    public void holdmove()
    {
  
       
        
        float xinput =Input.GetAxis("Horizontal");
        float yinput = Input.GetAxis("Vertical");


      
            Limit();
       
        Vector3 tran = transform.position;
        if (xinput < 0)
        {
           
            tran.x -= speed * Time.deltaTime;
        }
        else if (xinput > 0)
        {
            tran.x += speed * Time.deltaTime;
        }
        if (yinput > 0)
        {
            tran.y += speed * Time.deltaTime;
        }
        else if (yinput < 0)
        {
            tran.y -= speed * Time.deltaTime;
        }
        transform.position = tran;


        
    }
    public void AnotherMove()
    {
        
        transform.position=(new Vector3(14.59f, transform.position.y, 0f)*speed*Time.deltaTime);


    }
    public void sliders(int health)
    {
        Currenthealth-=health;
        slider.sliderhealth(Currenthealth);

    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

          
            Anim.SetTrigger("Hurt");
            sliders(20);
          
            
            if (Currenthealth == 0)
            {
                Transprent.SetActive(true);
                Pause.SetActive(false);
                Gameover.SetActive(true);
                Health.SetActive(false);
                Scores.SetActive(false);
                Time.timeScale = 0f;
            }
            if (Currenthealth == 30)
            {
                Thruster.SetActive(false);
                fire.SetActive(true);
              
             
            }
          
            else if (Currenthealth == 0)
            {
             
                source.clip = gameover;
                source.Play();
                fire.SetActive(false);
             
                Thruster.SetActive(false);
                Destroy(this.gameObject, 2f);
              
                Anim.SetBool("Expo", true);
               
                ES.over();
            }
             
          
        
          
        }
        if (collision.gameObject.tag == "Shield")
        {
            CoverShield.SetActive(false);
            Anim.SetTrigger("Tackpower");
            Instantiate(Shield, transform.position, transform.rotation);
            source.clip = Powerup;
            source.Play();
            Destroy(collision.gameObject);
            Bunlimit.StopAllCoroutines();


        }
        if (collision.gameObject.tag == "Speed")
        {
            source.clip = Powerup;
            source.Play();

            CoverShield.SetActive(false);
            Bunlimit.StopAllCoroutines();
            Anim.SetTrigger("Tackpower");
        
            speed = 12f;
            Destroy(collision.gameObject);
           
        }
        if (collision.gameObject.tag == "Multibullet")
        {
            speed = 7f;
            CoverShield.SetActive(true);
            source.clip = Powerup;
            source.Play();
            Anim.SetTrigger("Tackpower");
            Bunlimit.Bullets();
            Destroy(collision.gameObject);
        }
        
       
        
    }
    public void speedon()
    {
        speed = 15f;
    }
    public void Limit()
    {
        if (transform.position.x>= Max)
        {
            transform.position = new Vector3(Max, transform.position.y, 0f);
        }
        if (transform.position.x<= Min)
        {
            transform.position = new Vector3(Min, transform.position.y, 0f);
        }
        if (transform.position.y >= Max2)
        {
            transform.position = new Vector3( transform.position.x, Min2, 0f);

        }
        else if (transform.position.y <= Min2)
        {
            transform.position = new Vector3(transform.position.x,Max2, 0f);
        }
    }
    public void enemysounds()
    {
        source.clip = enemyclip;
          source.Play();
      
    }
}
