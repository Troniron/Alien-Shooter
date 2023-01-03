using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgmusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] bg = GameObject.FindGameObjectsWithTag("Bgmusic");
        if (bg.Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
