using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject Bullet;
    private float canfire=0.0f;
    private float gunfire = 0.5f;
    public AudioSource aud;
    public AudioClip ac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canfire)
        {
            aud.clip = ac;
            aud.Play();
             instating();
        
          
        }
        
    }
    public void Firebutton()
    {
       if(Time.time > canfire)
        {
            aud.Play();
            aud.clip = ac;
            instating();
        }
     
    }
    public void instating()
    {
        canfire = Time.time + gunfire;
        Instantiate(Bullet,transform.position,transform.localRotation );
    }
}
