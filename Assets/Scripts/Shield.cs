using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private int timer;
 
    void Start()
    {
        timer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerControll.Instance.transform.position.x, PlayerControll.Instance.transform.position.y, PlayerControll.Instance.transform.position.z);
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
        
           timer -= 1;
           if (timer < 0)
           {
               Destroy(this.gameObject);
            }
       
        }
    }
}
