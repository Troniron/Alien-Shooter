using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Uimanager : MonoBehaviour
{
    public Text Scoretext,highscore,overscore,overhighscore;
    private int score,Lives,EHealth;
    private EnemySpawning ES;
   // public GameObject BigE, Text1, Text2, Text3, ptext1, ptext2, ptext3,Allhealth,EnemyAsset1, EnemyAsset2, EnemyAsset3,EnemyAsset4,Wall,Forward;//Health1,Health2,Health3;
   // public Text Enemyhealth;
   // public Animator am;
    public AudioSource source;
    [SerializeField]
    private AudioClip clip;
    public GameObject Bgforpause, transprant,pausebut,playbut,Gameover,Scores,Playerhealth;
    [SerializeField]
  //  private GameObject bgusic;
    private EnemySpawning Espawns;
    private PlayerControll player;
    private BulletUnlimitedspwan spawn;
    // Start is called before the first frame update
    void Start()
    {
      EHealth = 100;
        Lives = 3;
        highscore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        overhighscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
       
        player = GameObject.Find("Player").GetComponent<PlayerControll>();
        ES = GameObject.Find("EnemySpawn").GetComponent<EnemySpawning>();
        spawn = GameObject.Find("Bulletunlimited").GetComponent<BulletUnlimitedspwan>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void count()
    {
       
       
        score += 10;
        Scoretext.text = score.ToString();
        overscore.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            overhighscore.text = score.ToString();
            highscore.text = score.ToString();
           
        }
   
       
        
     
        if (Lives == 0)
        {
            ES.over();
        }
       
    }
    public void Ehealth()
    {
    

    }
    public void pause()
    {
        Time.timeScale = 0f;
        transprant.SetActive(true);
        Bgforpause.SetActive(true);
        playbut.SetActive(true);
        pausebut.SetActive(false);
        Scores.SetActive(false);
        Playerhealth.SetActive(false);
    }
    public void play()
    {
        Playerhealth.SetActive(true);
        playbut.SetActive(false);
        Time.timeScale = 1f;
        transprant.SetActive(false);
        Scores.SetActive(true);
        Bgforpause.SetActive(false);
        pausebut.SetActive(true);
    }
    public void playstart()
    {
        Time.timeScale = 1f;
        playbut.SetActive(false);
        transprant.SetActive(false);
        
        Bgforpause.SetActive(false);
    }
    public void Replayscen6()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highscore.text = "0";
        Gameover.SetActive(false);
        Scores.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene6");
    }
    public void Retry6()
    {
      //  PlayerPrefs.DeleteKey("HighScore");
        //highscore.text = "0";
        Gameover.SetActive(false);
        Scores.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene6");
    }
    public void Replayscene5()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highscore.text = "0";
        Gameover.SetActive(false);
        Scores.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }
    public void ButtonSound()
    {
        source.PlayOneShot(clip);
    }
    public void Retry5()
    {
       // PlayerPrefs.DeleteKey("HighScore");
      //  highscore.text = "0";
        Gameover.SetActive(false);
        Scores.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene5");

    }
    public void Replayscene7()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highscore.text = "0";
        Gameover.SetActive(false);
        Scores.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene7");

    }
    public void Retry7()
    {
       // PlayerPrefs.DeleteKey("HighScore");
      //  highscore.text = "0";
        Gameover.SetActive(false);
        Scores.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene7");

    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
      //  DontDestroyOnLoad(bgusic);
        Time.timeScale = 1f;
        Gameover.SetActive(false);
        

    }
    public void PlayerNolimit()
    {
        float speed = 10f;
        if (EHealth == 0)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }



    }
}
