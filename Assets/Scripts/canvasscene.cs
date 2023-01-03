using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class canvasscene : MonoBehaviour
{
    [SerializeField]
    private GameObject FlightSelection, menusidebar, MainMenu,Green,Red,Blue,Right1,Right2,Right3,Start1,Start2,Start3;
    private int selectflight = 0;
    [SerializeField]
    private AudioSource Source;
    [SerializeField]
    private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
       // Source.clip = Bgmusic;
      //  Source.Play();
       // DontDestroyOnLoad(Bgmusic);
    }

    // Update is called once per frame
    void Update()
    {
     
       
        
    }
    public void start()
    {
        
        SceneManager.LoadScene("Scene5");
        FlightSelection.SetActive(false);
      //  DontDestroyOnLoad(Bgmusic);
      
    }
    public void start2()
    {
        SceneManager.LoadScene("Scene6");
        FlightSelection.SetActive(false);
        //DontDestroyOnLoad(Bgmusic);

    }
    public void start3()
    {
        SceneManager.LoadScene("Scene7");
        FlightSelection.SetActive(false);
       // DontDestroyOnLoad(Bgmusic);

    }
    public void change()
    {
        Source.PlayOneShot(clip);
    }
    public void ChangePlayer()
    {
        menusidebar.SetActive(false);
        FlightSelection.SetActive(true);
     //   sideborder.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void Back()
    {
       
     //   sideborder.SetActive(false);
        FlightSelection.SetActive(false);
        menusidebar.SetActive(true);
        MainMenu.SetActive(true);
    }
    public void RightButton1()
    {
        Right2.SetActive(true);
        Right1.SetActive(false);
        Blue.SetActive(true);
        Green.SetActive(false);
        Red.SetActive(false);
        Right3.SetActive(false);

    }
    public void RightButton2()
    {
        Right3.SetActive(true);
        Right1.SetActive(false);
        Right2.SetActive(false);
        Green.SetActive(true);
        Blue.SetActive(false);
        Red.SetActive(false);


    }
    public void RightButton3()
    {
        Right1.SetActive(true);
        Right2.SetActive(false);
        Right3.SetActive(false);
        Red.SetActive(true);
        Green.SetActive(false);
        Blue.SetActive(false);
       


    }
    public void Flight1()
    {
        Start1.SetActive(true);
        Start2.SetActive(false);
        Start3.SetActive(false);
        FlightSelection.SetActive(false);
        menusidebar.SetActive(true);
       // sideborder.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Flight2()
    {
        menusidebar.SetActive(true);
       // sideborder.SetActive(false);

        Start1.SetActive(false);
        Start2.SetActive(true);
        Start3.SetActive(false);
        FlightSelection.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Flight3()
    {
        menusidebar.SetActive(true);
      //  sideborder.SetActive(false);

        Start1.SetActive(false);
        Start2.SetActive(false);
        Start3.SetActive(true);
        FlightSelection.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    void Flights()
    {
        int i = 0;
        foreach (Transform Flight in transform)
        {
            if (i == selectflight)
            {
                Flight.gameObject.SetActive(true);
            }
            else
            {
                Flight.gameObject.SetActive(false);
            }
            i++;

        }
    }
}
