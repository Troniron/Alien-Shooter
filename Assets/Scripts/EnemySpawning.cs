using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    private float Max, Min;
    public GameObject Enemy,ThreeBullut,speed,shields;
    private bool Stop = false, multi = false,speedon=false,shield=false;
    // Start is called before the first frame update
    void Start()
    {
        Max = 5.76f;
        Min = -3.65f;
        
        StartCoroutine(single());
        StartCoroutine(speeds());
        StartCoroutine(Shield());
        StartCoroutine(Multibullet());
      

      
    }
    public void Spawnthree()
    {
        //StartCoroutine(Multibullet());
    }
    public void Spawnthreeoff()
    {
        multi = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void speedy()
    {
      
    }
    public void speedsfall()
    {
        speedon = true;
    }

    public IEnumerator speeds()
    {
        while (speedon == false)
        {
            Vector3 pos = new Vector3(transform.position.x, Random.Range(Max, Min), 0);

            yield return new WaitForSeconds(Random.Range(10,15));
            Instantiate(speed, pos, transform.rotation);
        }
    }
    public IEnumerator Shield()
    {
        while (shield == false)
        {
            Vector3 pos = new Vector3(transform.position.x, Random.Range(Max, Min), 0);
            yield return new WaitForSeconds(Random.Range(20,30));
            Instantiate(shields, pos, transform.rotation);
        }
    }

    public IEnumerator Multibullet()
    {
        while (multi == false)
        {
            yield return new WaitForSeconds(14f);
            GameObject obg = Instantiate(ThreeBullut);

            float ypos = Random.Range(Max, Min);
            ThreeBullut.transform.position = new Vector2(transform.position.x, ypos);
            //  StartCoroutine(single());
        }

    }
    IEnumerator single()
    {
        while (Stop == false)
        {
            yield return new WaitForSeconds(Random.Range(0.2f, 0.8f));
            GameObject obg = Instantiate(Enemy);

            float ypos = Random.Range(Max, Min);
            Enemy.transform.position = new Vector2(transform.position.x, ypos);
         
        }
     


    }

  

    public void over()
    {
        Stop = true;
    }
}
