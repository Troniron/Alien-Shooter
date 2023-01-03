using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makesingledon : MonoBehaviour
{
    public static makesingledon Spaceship;
    // Start is called before the first frame update
    void Start()
    {
        Createpos();
    }

   public void Createpos()
    {
        if (Spaceship != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Spaceship = this;
        }
    }
}
