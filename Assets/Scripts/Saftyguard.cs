using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saftyguard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(makesingledon.Spaceship.transform.position.x, makesingledon.Spaceship.transform.position.y, makesingledon.Spaceship.transform.position.z);
    }
   
}
