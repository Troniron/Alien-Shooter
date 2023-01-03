using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUnlimitedspwan : MonoBehaviour
{
    [SerializeField]
    private GameObject Bulletspwnob;
    bool Stop;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Bullets()
    {
        StartCoroutine(Bulletspawn());
    }
   public  IEnumerator Bulletspawn()
    {
        while (Stop == false)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 1f) );
            GameObject obg = Instantiate(Bulletspwnob);
            float ypos = Random.Range(5.76f, -3.65f);
            Bulletspwnob.transform.position = new Vector2(transform.position.x, ypos);

        }
    }
  

    
}
